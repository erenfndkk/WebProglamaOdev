using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.DataAccessLayer.Concreate;
using WebProgramlamaOdev.EntityLayer.Concreate;
using WebProgramlamaOdev.WebUI.Models.Doktor;
using WebProgramlamaOdev.WebUI.Models.Hasta;
using WebProgramlamaOdev.WebUI.Models.Randevu;

namespace WebProgramlamaOdev.WebUI.Controllers
{
    public class HastaController : Controller
    {
        private readonly IPoliklinikService _poliklinikService;
        private readonly IDoktorService _doktorService;
        private readonly IRandevuService _randevuService;
        private readonly Context _context;

        public HastaController(IPoliklinikService poliklinikService, IDoktorService doktorService, IRandevuService randevuService, Context context)
        {
            _poliklinikService = poliklinikService;
            _doktorService = doktorService;
            _randevuService = randevuService;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Randevularim()
        {
            var loggedInUserTC = HttpContext.Session.GetString("UserTC");
            var randevular = _context.Randevu
                .Include(r => r.Doktor)
                .Include(r => r.Poliklinik)
                .Where(r => r.HastaTC == loggedInUserTC)
                .ToList();

            return View(randevular);
        }
        [HttpGet]
        public IActionResult RandevuAl()
        {
            var poliklinikler = _poliklinikService.TGetList();
            ViewBag.PoliklinikListesi = new SelectList(poliklinikler, "PoliklinikId", "PoliklinikAd"); ;

            var doktorlar = _doktorService.TGetList(); 

            if (doktorlar != null)
            {
                var doktorAdSoyadListesi = doktorlar.Select(d => new
                {
                    DoktorId = d.DoktorId,
                    DoktorAdSoyad = $"{d.DoktorAd} {d.DoktorSoyad}"
                }).ToList();

                ViewBag.DoktorListesi = new SelectList(doktorAdSoyadListesi, "DoktorId", "DoktorAdSoyad");
            }
            else
            {
                ViewBag.DoktorListesi = new SelectList(new List<Doktor>(), "DoktorId", "DoktorAdSoyad");
            }
            return View();

        }
        [HttpPost]
        public IActionResult RandevuAl(int randevuId)
        {
            var randevu = _context.Randevu.FirstOrDefault(r => r.RandevuId == randevuId);

            if (randevu != null)
            {
                var loggedInUserTC = HttpContext.Session.GetString("UserTC"); 
                if (!string.IsNullOrEmpty(loggedInUserTC))
                {
                    randevu.HastaTC = loggedInUserTC;
                    randevu.Durum = true;

                    _context.SaveChanges();

                    return Ok();
                }
            }
            return BadRequest();
        }
        public IActionResult ListRandevular(int poliklinikId, int doktorId)
        {
            var randevular = _context.Randevu
                .Include(r => r.Doktor)
                .Include(r => r.Poliklinik)
                .Where(r => r.PoliklinikId == poliklinikId && r.DoktorId == doktorId && r.Durum == false)
                .ToList();

            return View(randevular);
        }
    }
}

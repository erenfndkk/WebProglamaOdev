using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using System.Text;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.DataAccessLayer.Concreate;
using WebProgramlamaOdev.EntityLayer.Concreate;
using WebProgramlamaOdev.WebUI.Models.Poliklinik;
using WebProgramlamaOdev.WebUI.Models.Randevu;

namespace WebProgramlamaOdev.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RandevuuController : Controller
    {
        //private readonly IHttpClientFactory _httpClientFactory;

        //public RandevuuController(IHttpClientFactory httpClientFactory)
        //{
        //    _httpClientFactory = httpClientFactory;
        //}
        //public async Task<IActionResult> Index()
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync("http://localhost:5098/api/Randevu");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<List<RandevuViewModel>>(jsonData);
        //        return View(values);
        //    }
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult AddRandevu()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> AddRandevu(AddRandevuViewModel addRandevuViewModel)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var jsonData = JsonConvert.SerializeObject(addRandevuViewModel);
        //    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        //    var responseMessage = await client.PostAsync("http://localhost:5098/api/Randevu", stringContent);
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //public async Task<IActionResult> DeleteRandevu(int id)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.DeleteAsync($"http://localhost:5098/api/Randevu/{id}");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //[HttpGet]
        //public async Task<IActionResult> UpdateRandevu(int id)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync($"http://localhost:5098/api/Randevu/{id}");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<UpdateRandevuViewModel>(jsonData);
        //        return View(values);
        //    }
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> UpdateRandevu(UpdateRandevuViewModel model)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var jsonData = JsonConvert.SerializeObject(model);
        //    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        //    var responseMessage = await client.PutAsync("http://localhost:5098/api/Randevu/", stringContent);
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        private readonly IRandevuService _randevuService;
        private readonly IDoktorService _doktorService;
        private readonly Context _context;

        public RandevuuController(IRandevuService randevuService, IDoktorService doktorService, Context context)
        {
            _randevuService = randevuService;
            _doktorService = doktorService;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Randevu.Include(c => c.Doktor).Include(c => c.Poliklinik).ToList());
            //var values = _randevuService.TGetList(); bu şekilde listelersek doktor ve poliklinik isimleri yerine id leri geliyor.
            //return View(values);
        }
        [HttpGet]
        public IActionResult AddRandevu()
        {
            var dbContext = new Context(); // Bu kısmı kendi context sınıfınıza uygun şekilde değiştirebilirsiniz
            ViewBag.Doctors = dbContext.Doktor.Select(d => new { d.DoktorId, FullName = d.DoktorAd + " " + d.DoktorSoyad }).ToList();
            ViewBag.Poliklinikler = dbContext.Poliklinik.Select(p => new {p.PoliklinikId, p.PoliklinikAd}).ToList();
            return View();
            
        }
        [HttpPost]
        public IActionResult AddRandevu(Randevu randevu)
        {
            _randevuService.TInsert(randevu);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteRandevu(int id)
        {
            var values = _randevuService.TGetByID(id);
            _randevuService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateRandevu(int id)
        {
            var value = _randevuService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateRandevu(Randevu randevu)
        {

            _randevuService .TUpdate(randevu);
            return RedirectToAction("Index");

        }
    }
}

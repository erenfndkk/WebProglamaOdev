using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.BusinessLayer.Concreate;
using WebProgramlamaOdev.DataAccessLayer.Concreate;
using WebProgramlamaOdev.DataAccessLayer.EntityFramework;
using WebProgramlamaOdev.EntityLayer.Concreate;
using WebProgramlamaOdev.WebUI.Models.Doktor;

namespace WebProgramlamaOdev.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DoktorrController : Controller
    {
        //private readonly IHttpClientFactory _httpClientFactory;

        //public DoktorrController(IHttpClientFactory httpClientFactory)
        //{
        //    _httpClientFactory = httpClientFactory;
        //}

        //public async Task<IActionResult> Index()
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync("http://localhost:5098/api/Doktor");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<List<DoktorViewModel>>(jsonData);
        //        return View(values);
        //    }
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult AddDoktorr()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> AddDoktorr(AddDoktorViewModel addDoktorViewModel)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var jsonData = JsonConvert.SerializeObject(addDoktorViewModel);
        //    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        //    var responseMessage = await client.PostAsync("http://localhost:5098/api/Doktor", stringContent);
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //public async Task<IActionResult> DeleteDoktorr(int id)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.DeleteAsync($"http://localhost:5098/api/Doktor/{id}");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //[HttpGet]
        //public async Task<IActionResult> UpdateDoktor(int id)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync($"http://localhost:5098/api/Doktor/{id}");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<UpdateDoktorViewModel>(jsonData);
        //        return View(values);
        //    }
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> UpdateDoktor(UpdateDoktorViewModel model)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var jsonData = JsonConvert.SerializeObject(model);
        //    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        //    var responseMessage = await client.PutAsync("http://localhost:5098/api/Doktor/", stringContent);
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        //*********************************************************************************//

        private readonly IDoktorService _doktorService;
        private readonly Context _context;

        public DoktorrController(IDoktorService doktorService, Context context)
        {
            _doktorService = doktorService;
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Doktor.Include(c => c.AnaBilimDali).Include(p => p.Poliklinik).ToList();
            return View(values);
            //var values = _doktorService.TGetList();
           // return View(values);
        }
        [HttpGet]
        public IActionResult AddDoktorr()
        { 
            //ViewBag.AnaBilimDalis = _context.AnaBilimDali.Select(a => new {a.AnaBilimDaliId, a.AnaBilimDaliAd}).ToList();
            //ViewBag.Poliknikkk = _context.Poliklinik.Select(a => new {a.PoliklinikId, a.PoliklinikAd}).ToList();

            ViewBag.AnaBilimDalis = _context.AnaBilimDali.Select(a => new SelectListItem
            {
                Value = a.AnaBilimDaliId.ToString(),
                Text = a.AnaBilimDaliAd
            }).ToList();

            ViewBag.Poliknikkk = _context.Poliklinik.Select(a => new SelectListItem
            {
                Value = a.PoliklinikId.ToString(),
                Text = a.PoliklinikAd
            }).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddDoktorr(Doktor doktor)
        {

            _doktorService.TInsert(doktor);
            return RedirectToAction("Index");

        }
        public IActionResult DeleteDoktorr(int id)
        {
            var values = _doktorService.TGetByID(id);
            _doktorService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateDoktor(int id)
        {
            //ViewBag.AnaBilimDalis = _context.AnaBilimDali.Select(a => new { a.AnaBilimDaliId, a.AnaBilimDaliAd }).ToList();
            //ViewBag.Poliknik = _context.Poliklinik.Select(a => new { a.PoliklinikId, a.PoliklinikAd }).ToList();

            ViewBag.AnaBilimDalis = _context.AnaBilimDali.Select(a => new SelectListItem
            {
                Value = a.AnaBilimDaliId.ToString(),
                Text = a.AnaBilimDaliAd
            }).ToList();

            ViewBag.Poliknikkk = _context.Poliklinik.Select(a => new SelectListItem
            {
                Value = a.PoliklinikId.ToString(),
                Text = a.PoliklinikAd
            }).ToList();
            var value = _doktorService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateDoktor(Doktor doktor)
        {

            _doktorService.TUpdate(doktor);
            return RedirectToAction("Index");

        }

    }
}

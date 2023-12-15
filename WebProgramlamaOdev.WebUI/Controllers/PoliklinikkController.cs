using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Text;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.EntityLayer.Concreate;
using WebProgramlamaOdev.WebUI.Models.Doktor;
using WebProgramlamaOdev.WebUI.Models.Poliklinik;

namespace WebProgramlamaOdev.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PoliklinikkController : Controller
    {
        //private readonly IHttpClientFactory _httpClientFactory;

        //public PoliklinikkController(IHttpClientFactory httpClientFactory)
        //{
        //    _httpClientFactory = httpClientFactory;
        //}
        //public async Task<IActionResult> Index()
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync("http://localhost:5098/api/Poliklinik");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<List<PoliklinikViewModel>>(jsonData);
        //        return View(values);
        //    }
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult AddPoliklinik()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> AddPoliklinik(AddPoliklinikViewModel addPoliklinikViewModel)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var jsonData = JsonConvert.SerializeObject(addPoliklinikViewModel);
        //    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        //    var responseMessage = await client.PostAsync("http://localhost:5098/api/Poliklinik", stringContent);
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //public async Task<IActionResult> DeletePoliklinik(int id)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.DeleteAsync($"http://localhost:5098/api/Poliklinik/{id}");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //[HttpGet]
        //public async Task<IActionResult> UpdatePoliklinik(int id)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync($"http://localhost:5098/api/Poliklinik/{id}");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<UpdatePoliklinikViewModel>(jsonData);
        //        return View(values);
        //    }
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> UpdatePoliklinik(UpdatePoliklinikViewModel model)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var jsonData = JsonConvert.SerializeObject(model);
        //    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        //    var responseMessage = await client.PutAsync("http://localhost:5098/api/Poliklinik/", stringContent);
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        private readonly IPoliklinikService _poliklinikService;

        public PoliklinikkController(IPoliklinikService poliklinikService)
        {
            _poliklinikService = poliklinikService;
        }

        public IActionResult Index()
        {
            var values = _poliklinikService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPoliklinik()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPoliklinik(Poliklinik poliklinik)
        {

            _poliklinikService.TInsert(poliklinik);
            return RedirectToAction("Index");

        }
        public IActionResult DeletePoliklinik(int id)
        {
            var values = _poliklinikService.TGetByID(id);
            _poliklinikService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdatePoliklinik(int id)
        {
            var value = _poliklinikService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePoliklinik(Poliklinik poliklinik)
        {

            _poliklinikService.TUpdate(poliklinik);
            return RedirectToAction("Index");

        }
    }
}

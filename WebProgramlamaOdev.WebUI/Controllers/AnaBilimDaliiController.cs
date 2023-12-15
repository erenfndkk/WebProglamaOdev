using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.EntityLayer.Concreate;
using WebProgramlamaOdev.WebUI.Models.AnaBilimDali;
using WebProgramlamaOdev.WebUI.Models.Doktor;

namespace WebProgramlamaOdev.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AnaBilimDaliiController : Controller
    {
        //private readonly IHttpClientFactory _httpClientFactory;

        //public AnaBilimDaliiController(IHttpClientFactory httpClientFactory)
        //{
        //    _httpClientFactory = httpClientFactory;
        //}
        //public async Task<IActionResult> Index()
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync("http://localhost:5098/api/AnaBilimDali");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<List<AnaBilimDaliViewModel>>(jsonData);
        //        return View(values);
        //    }
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult AddAnaBilimDali()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> AddAnaBilimDali(AddAnaBilimDaliViewModel addAnaBilimDaliViewModel)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var jsonData = JsonConvert.SerializeObject(addAnaBilimDaliViewModel);
        //    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        //    var responseMessage = await client.PostAsync("http://localhost:5098/api/AnaBilimDali", stringContent);
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //public async Task<IActionResult> DeleteAnaBilimDali(int id)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.DeleteAsync($"http://localhost:5098/api/AnaBilimDali/{id}");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //[HttpGet]
        //public async Task<IActionResult> UpdateAnaBilimDali(int id)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync($"http://localhost:5098/api/AnaBilimDali/{id}");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<UpdateAnaBilimDaliViewModel>(jsonData);
        //        return View(values);
        //    }
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> UpdateAnaBilimDali(UpdateAnaBilimDaliViewModel model)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var jsonData = JsonConvert.SerializeObject(model);
        //    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        //    var responseMessage = await client.PutAsync("http://localhost:5098/api/AnaBilimDali/", stringContent);
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        private readonly IAnaBilimDaliService _anaBilimDaliService;

        public AnaBilimDaliiController(IAnaBilimDaliService anaBilimDaliService)
        {
            _anaBilimDaliService = anaBilimDaliService;
        }

        public IActionResult Index()
        {
            var values = _anaBilimDaliService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnaBilimDali()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnaBilimDali(AnaBilimDali anaBilimDali)
        {

            _anaBilimDaliService.TInsert(anaBilimDali);
            return RedirectToAction("Index");

        }
        public IActionResult DeleteAnaBilimDali(int id)
        {
            var values = _anaBilimDaliService.TGetByID(id);
            _anaBilimDaliService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAnaBilimDali(int id)
        {
            var value = _anaBilimDaliService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAnaBilimDali(AnaBilimDali anaBilimDali)
        {

            _anaBilimDaliService.TUpdate(anaBilimDali);
            return RedirectToAction("Index");

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebProgramlamaOdev.WebUI.Models.Doktor;

namespace WebProgramlamaOdev.WebUI.Controllers
{
    public class DoktorrController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DoktorrController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5098/api/Doktor");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<DoktorViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

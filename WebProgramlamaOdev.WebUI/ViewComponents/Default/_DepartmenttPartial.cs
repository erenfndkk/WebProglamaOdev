using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebProgramlamaOdev.WebUI.Models.Department;

namespace WebProgramlamaOdev.WebUI.ViewComponents.Default
{
    public class _DepartmenttPartial :ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DepartmenttPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5098/api/Department");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<DepartmentViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

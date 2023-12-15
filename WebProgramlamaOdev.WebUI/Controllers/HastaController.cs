using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using WebProgramlamaOdev.WebUI.Models.Doktor;
using WebProgramlamaOdev.WebUI.Models.Hasta;

namespace WebProgramlamaOdev.WebUI.Controllers
{
    public class HastaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

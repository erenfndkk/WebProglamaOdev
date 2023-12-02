using Microsoft.AspNetCore.Mvc;

namespace WebProgramlamaOdev.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace WebProgramlamaOdev.WebUI.ViewComponents.Default
{
    public class _ScriptsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace WebProgramlamaOdev.WebUI.ViewComponents.Default
{
    public class _AboutPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

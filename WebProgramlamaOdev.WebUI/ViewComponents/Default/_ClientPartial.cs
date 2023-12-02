using Microsoft.AspNetCore.Mvc;

namespace WebProgramlamaOdev.WebUI.ViewComponents.Default
{
    public class _ClientPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

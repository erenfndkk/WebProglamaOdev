using Microsoft.AspNetCore.Mvc;

namespace WebProgramlamaOdev.WebUI.ViewComponents.Default
{
    public class _ContactPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

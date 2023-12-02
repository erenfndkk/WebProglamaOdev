using Microsoft.AspNetCore.Mvc;

namespace WebProgramlamaOdev.WebUI.ViewComponents.Default
{
    public class _DepartmentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

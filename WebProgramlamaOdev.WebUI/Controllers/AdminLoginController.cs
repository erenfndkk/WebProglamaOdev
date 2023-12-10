using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.DataAccessLayer.Concreate;

namespace WebProgramlamaOdev.WebUI.Controllers
{
    public class AdminLoginController : Controller
    {
        private readonly Context _context;

        public AdminLoginController(Context context)
        {
            _context = context;
        }

        public IActionResult Index(string username, string password)
        {
            var admin = _context.Admin.FirstOrDefault(x => x.AdminKullaniciAdi == username);

            if (admin != null && admin.AdminSifre == password)
            {
                return RedirectToAction("Index", "Doktorr");
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            return View();
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.EntityLayer.Concreate;
using WebProgramlamaOdev.WebUI.Dtos;

namespace WebProgramlamaOdev.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateNewHastaDto createNewHastaDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var hasta = new AppUser()
            {
                Name = createNewHastaDto.HastaAd,
                Surname = createNewHastaDto.HastaSoyad,
                Email = createNewHastaDto.HastaMail        
            };
            var result = await _userManager.CreateAsync(hasta, createNewHastaDto.HastaSifre);
            if (result.Succeeded) 
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}

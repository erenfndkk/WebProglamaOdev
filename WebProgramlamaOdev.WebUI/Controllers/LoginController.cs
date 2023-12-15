using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.EntityLayer.Concreate;
using WebProgramlamaOdev.WebUI.Dtos.AdminDto;
using WebProgramlamaOdev.WebUI.Dtos.LoginDto;

namespace WebProgramlamaOdev.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto loginUserDto)
        {
            //if(ModelState.IsValid)
            //{
            //    var result = await _signInManager.PasswordSignInAsync(loginUserDto.Username, loginUserDto.Password, false, false);
            //    if (result.Succeeded)
            //    {
            //        return RedirectToAction("Index", "Profile");
            //    }
            //}
            //return View();

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginUserDto.Username, loginUserDto.Password, false, false);
                if (result.Succeeded)
                {
                    var user = await _signInManager.UserManager.FindByNameAsync(loginUserDto.Username);

                    if (await _signInManager.UserManager.IsInRoleAsync(user, "Admin"))
                    {
                        return RedirectToAction("Index", "Doktorr"); // Admin paneline yönlendirme
                    }
                    else if (await _signInManager.UserManager.IsInRoleAsync(user, "Hasta"))
                    {
                        var hasta = new LoginUserDto
                        {
                            Username = user.UserName
                            // Görüntülemek istediğiniz diğer özellikleri ekleyin
                        };
                        TempData["Username"] = hasta.Username;

                        return RedirectToAction("Index", "Hasta", hasta); // User paneline yönlendirme
                    }
                }
            }
            return View();
        }
    }
}

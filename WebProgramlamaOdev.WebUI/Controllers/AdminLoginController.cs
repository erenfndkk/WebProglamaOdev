﻿using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.DataAccessLayer.Concreate;

namespace WebProgramlamaOdev.WebUI.Controllers
{
    public class AdminLoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

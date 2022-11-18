using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_11_17.Models;

namespace MVC_11_17.Controllers
{
    public class AccountController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AccountView()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return RedirectToAction("Index");
        }

        

    }
}

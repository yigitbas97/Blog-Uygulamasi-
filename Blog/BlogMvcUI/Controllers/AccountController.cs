using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BlogMvcUI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace BlogMvcUI.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new LoginViewModel { UserName = loginViewModel.UserName, Password = loginViewModel.Password };

                if (user.UserName == "yigitAdmin" && user.Password == "deneme")
                {
                    var identity = new ClaimsIdentity(new[]
{
                        new Claim(ClaimTypes.Name, user.UserName)
                    },
                    CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    return RedirectToAction("Index", "Admin");
                }

                TempData["message"] = "User did not found !";
                return View();
            }

            return View();
        }

        public IActionResult LogOff()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme).Wait();
            return RedirectToAction("Login");
        }
    }
}
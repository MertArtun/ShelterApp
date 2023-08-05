using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ShelterApp.Identity;
using ShelterApp.Models;

namespace ShelterApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            AppUser user = await _userManager.FindByEmailAsync(model.Email);

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Beklenmeyen bir hata oluştu");
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            System.Console.WriteLine(JsonConvert.SerializeObject(model));
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            AppUser user = new(){
                UserName = Guid.NewGuid().ToString(),
                Firstname = model.Firstname,
                Lastname = model.Lastname,
                Email = model.Email,
                PhoneNumber = model.Phonenumber
            };

            IdentityResult result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Beklenmeyen bir hata oluştu");
            }

            return RedirectToAction("Login");
        }
    }
}
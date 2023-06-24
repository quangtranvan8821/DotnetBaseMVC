using Microsoft.AspNetCore.Mvc;
using DotnetBaseMVCApp.Models;
using DotnetBaseMVCApp.ViewModels;
using System;
using System.Text.Json;

namespace DotnetBaseMVCApp.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel("", "");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            string email = model.email;
            string password = model.password;

            Account account = new Account("quangtrn8821@email.com", "12345678");
            // Console.WriteLine(JsonSerializer.Serialize(account));
            // Console.WriteLine(email);
            // Console.WriteLine(password);
            return View(model);
        }

        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}
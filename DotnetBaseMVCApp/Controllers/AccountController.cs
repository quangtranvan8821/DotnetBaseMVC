using Microsoft.AspNetCore.Mvc;
using DotnetBaseMVCApp.Models;
using DotnetBaseMVCApp.ViewModels;
using DotnetBaseMVCApp.Data;
using DotnetBaseMVCApp.Interfaces;
using System;
using System.Text.Json;

namespace DotnetBaseMVCApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IAccountRepository _accountRepository;

        public AccountController(ApplicationDbContext context, IAccountRepository accountRepository)
        {
            _context = context;
            _accountRepository = accountRepository;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {

                Account account = new Account
                {
                    name = model.name,
                    email = model.email,
                    password = model.password
                };

                _accountRepository.Create(account);
                return Task.FromResult<IActionResult>(RedirectToAction("Index"));
            }
            else
            {
                ModelState.AddModelError("", "Data is invalid");
            }
            // var account = _accountRepository.Create(model);
            return Task.FromResult<IActionResult>(View(model));
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel("", "");
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {

            string email = model.email;
            string password = model.password;

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
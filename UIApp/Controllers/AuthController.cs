using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete.IdentityConcrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UIApp.Models;

namespace UIApp.Controllers
{
    
    [AllowAnonymous]
    public class AuthController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public AuthController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        //[HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Signup(UserRegisterViewModel user)
        {
            AppUser appNewUser = new AppUser()
            {
                Name = user.Name,
                Surname = user.SurName,
                Email = user.Email,
                UserName = user.UserName
            };
           
            if(user.Password == user.ConfirmPassword)
            {
                    var result = await _userManager.CreateAsync(appNewUser, user.Password = "");
                    if(result.Succeeded)
                    {
                        return RedirectToAction("Signin");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
            }
            return View(user);
        }


        [HttpGet]
        public IActionResult Signin()
        {
            return View();
        }

        // [HttpPost]
        // public IActionResult Signin(string s)
        // {
        //     return View();
        // }

        
    }
}
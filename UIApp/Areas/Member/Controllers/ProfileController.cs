using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete.IdentityConcrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UIApp.Areas.Member.Models;
namespace UIApp.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserProfileViewModel viewModel = new UserProfileViewModel
            {
                Name = values.Name,
                SurName = values.Surname,
                Email = values.Email,
                UserName = values.UserName,
                PhoneNumber = values.PhoneNumber,
                ImageUrl = values.ImageUrl
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserProfileViewModel userProfile)
        {
            
            
                if(userProfile.Password is not null && userProfile.Password == userProfile.ConfirmPassword)
                {
                    
                    
                
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                
                if(userProfile.FormFile != null)
                {
                    var imageName =  await FileHelper.UploadFile(userProfile.FormFile);
                    user.ImageUrl = imageName;
                }
                user.Name = userProfile.Name;
                user.Surname = userProfile.SurName;
                user.ImageUrl = user.ImageUrl;
                user.PhoneNumber = userProfile.PhoneNumber;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userProfile.Password);
                var result = await _userManager.UpdateAsync(user);
                if(result.Succeeded)
                {
                    return RedirectToAction("Signin", "Auth");
                }
                 else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

                }
                return RedirectToAction("Index");
        }


        
    }
}
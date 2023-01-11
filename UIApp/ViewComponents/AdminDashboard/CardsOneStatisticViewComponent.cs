using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete.IdentityConcrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UIApp.Models;

namespace UIApp.ViewComponents.AdminDashboard
{
    public class CardsOneStatisticViewComponent:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IDestinationService _destinationService;

        public CardsOneStatisticViewComponent(IDestinationService destinationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
             CardsOneStatisticModel viewModel = new CardsOneStatisticModel
             {
                 DestinationCount = _destinationService.GetAll().Data.Count,
                 UserCount = _userManager.Users.Count()
             };
             return View(viewModel);
        }
    }
}
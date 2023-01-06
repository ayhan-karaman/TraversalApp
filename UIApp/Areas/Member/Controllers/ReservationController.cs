using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.IdentityConcrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UIApp.Areas.Member.Models;

namespace UIApp.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ReservationController : Controller
    {
        
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;
        private readonly UserManager<AppUser> _userManager;


        public ReservationController(IDestinationService destinationService, IReservationService reservationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservations()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            
            var  reservationList = _reservationService.GetAllReservationByUserIdAndStatusCurrent(value.Id);
         
            return View(reservationList);
        }
        public async Task<IActionResult> MyOldReservations()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            
            var  reservationList = _reservationService.GetAllReservationByUserIdAndStatusOld(value.Id);
         
            return View(reservationList);
        }
        public async Task<IActionResult> MyWaitingForApprovalReservations()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            
            var  reservationList = _reservationService.GetAllReservationByUserIdAndStatusWaitApproval(value.Id);
         
            return View(reservationList);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            var reservationViewModel = new ReservationAddViewModel
            {
                  Reservation = new Reservation(),
                  Destinations = _destinationService.GetAll().Data

            };
            
            return View(reservationViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation reservation)
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            reservation.AppUserId = value.Id;
            _reservationService.Add(reservation);
            return RedirectToAction("MyWaitingForApprovalReservations", "Reservation", new{area = "Member"});
        }
    }
}
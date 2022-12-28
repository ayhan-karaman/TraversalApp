using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
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
    

        public ReservationController(IDestinationService destinationService, IReservationService reservationService)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
        }

        public IActionResult MyCurrentReservations()
        {
            return View();
        }
        public IActionResult MyOldReservations()
        {
            return View();
        }
        public IActionResult MyWaitingForApprovalReservations()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            var reservationViewModel = new ReservationAddViewModel
            {
                  Reservation = new Reservation(),
                  Destinations = _destinationService.GetAll()

            };
            
            return View(reservationViewModel);
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserId = 1;
            _reservationService.Add(reservation);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}
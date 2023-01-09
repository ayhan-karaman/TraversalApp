using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UIApp.Areas.Admin.Models;

namespace UIApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    [Route("Admin/[controller]/[action]")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IDestinationImageService _destinationImageService;
        public DestinationController(IDestinationService destinationService, IDestinationImageService destinationImageService)
        {
            _destinationService = destinationService;
            _destinationImageService = destinationImageService;
        }

        public IActionResult Index()
        {
            var destinations =  _destinationService.GetAll().Data;

         
            return View(destinations);
        }

       [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddDestination(DestinationAddViewModel addViewModel)
        {
             
           
                var result =  _destinationService.AddDestinationAndImage(addViewModel.FormFiles, addViewModel.Destination);
                if(!result.Success)
                {
                    TempData.Add("errorMessage", result.Message);
                    return RedirectToAction("AddDestination", "Destination", new{area = "Admin"});
                }
                    TempData.Add("successMessage", result.Message);
                    return RedirectToAction("Index", "Destination", new{area = "Admin"});
        }


      
        public IActionResult DeleteDestination(int id)
        {
              var destination = _destinationService.GetById(id).Data;
              var result =  _destinationService.Delete(destination);
               if(result.Success)
                    return RedirectToAction("Index", "Destination", new{area = "Admin"});
                return RedirectToAction("Index", "Destination", new{area = "Admin"});
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var result = _destinationService.GetById(id);
            if(result.Success)
                return View(result.Data);
            return View(result.Data);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            Console.WriteLine(destination.City);
            var result =  _destinationService.Update(destination);
            if(!result.Success)
                return RedirectToAction("UpdateDestination", "Destination", new{id = destination.ID});
            return RedirectToAction("Index", "Destination", new{area = "Admin"});
        }

    }
}
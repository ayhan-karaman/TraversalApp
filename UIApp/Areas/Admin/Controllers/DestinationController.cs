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
             
           if(addViewModel.FormFiles.Count > 0 && addViewModel.FormFiles.Count < 4)
            {
                _destinationService.Add(addViewModel.Destination);
                var result  =  _destinationImageService.AddImage(addViewModel.FormFiles, addViewModel.Destination.ID);
                if(!result.Success)
                {
                    return RedirectToAction("AddDestination", "Destination", new{area = "Admin"});
                }
                return RedirectToAction("Index", "Destination", new{area = "Admin"});
            }
            
            return RedirectToAction("AddDestination", "Destination", new{area = "Admin"});
        }


      
        public IActionResult DeleteDestination(int id)
        {
              var destination = _destinationService.GetById(id);
              _destinationService.Delete(destination);
               return RedirectToAction("Index", "Destination", new{area = "Admin"});
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var value = _destinationService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.Update(destination);
             return RedirectToAction("Index", "Destination", new{area = "Admin"});
        }

    }
}
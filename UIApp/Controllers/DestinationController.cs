using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UIApp.Controllers
{
   
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var data = _destinationService.GetAllDestinationIncludes();
            return View(data);
        }

        public IActionResult DestinationDetails(int id)
        {
                ViewBag.id = id;
                var destination = _destinationService.GetByIdDestinationIncludes(id);
                return View(destination);
        }

       
    }
}
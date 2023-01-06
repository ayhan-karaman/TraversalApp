using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UIApp.ViewComponents.Home
{
    public class StatisticsViewComponent:ViewComponent
    {
        private readonly IDestinationService _destinationService;
        private readonly IGuideService  _guideService;

        public StatisticsViewComponent(IGuideService guideService, IDestinationService destinationService)
        {
            _guideService = guideService;
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _destinationService.GetAll().Data.Count;
            ViewBag.v2 = _guideService.GetAll().Data.Count;
            ViewBag.v3 = 333;
            ViewBag.v4 = 28;
            return View();
        }
    }
}
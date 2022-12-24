using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UIApp.ViewComponents.Home
{
    public class PopularDestinationViewComponent : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public PopularDestinationViewComponent(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var datas = _destinationService.GetAllDestinationIncludes();
            
            return View(datas);
        }
    }
}
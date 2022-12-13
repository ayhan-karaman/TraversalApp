using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UIApp.ViewComponents.Home
{
    public class SubAboutViewComponent:ViewComponent
    {
        private readonly ISubAboutService _subAboutService;

        public SubAboutViewComponent(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var data = _subAboutService.GetAll();
            return View(data);
        }
    }
}
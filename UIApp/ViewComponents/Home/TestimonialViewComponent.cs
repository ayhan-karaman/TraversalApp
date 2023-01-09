using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UIApp.ViewComponents.Home
{
    public class TestimonialViewComponent:ViewComponent
    {
        private ITestimonialService _testimonialService;

        public TestimonialViewComponent(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _testimonialService.GetAll();
            if(result.Success)
                return View(result.Data);
            else
            {
                ViewData.Add("message", result.Message);
                return View();
            }
        }
    }
}
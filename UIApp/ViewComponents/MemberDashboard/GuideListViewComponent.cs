using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UIApp.ViewComponents.MemberDashboard
{
    public class GuideListViewComponent:ViewComponent
    {
         private readonly IGuideService _guideService;

        public GuideListViewComponent(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _guideService.GetAll();
            if(result.Success)
                return View(result.Data);
            else
            {
                return View(result.Data);
            }
        }
    }
}
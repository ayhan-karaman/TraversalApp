using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UIApp.ViewComponents.AdminDashboard
{
    public class AdminGuideList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
             return View();
        }
    }
}
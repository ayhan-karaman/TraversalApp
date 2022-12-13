using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UIApp.ViewComponents.Home
{
    public class FeatureViewComponent:ViewComponent
    {
        private readonly IFeatureService _featureService;

        public FeatureViewComponent(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            var data = _featureService.GetAll();
            return View(data);
        }
    }
}
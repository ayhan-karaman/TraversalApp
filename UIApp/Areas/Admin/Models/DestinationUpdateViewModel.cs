using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace UIApp.Areas.Admin.Models
{
    public class DestinationUpdateViewModel
    {
        public Destination Destination { get; set; }
        public List<DestinationImage> DestinationImages { get; set; }
        public ICollection<IFormFile> FormFiles { get; set; }
    }
}
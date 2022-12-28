using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace UIApp.Areas.Member.Models
{
    public class ReservationAddViewModel
    {
        public Reservation Reservation { get; set; }
        public ICollection<Destination> Destinations { get; set; }
    }
}
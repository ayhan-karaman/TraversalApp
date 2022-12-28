using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete.IdentityConcrete;

namespace Entities.Concrete
{
    public class Reservation
    {
        public int ID { get; set; }
        public int AppUserId { get; set; }
        public int DestinationID { get; set; }
        public int PersonCount { get; set; }
        public string Description { get; set; }
        public DateTime ReservationDate { get; set; }
        public Destination Destination { get; set; }
        public string Status { get; set; }
        public AppUser AppUser { get; set; }
    }
}
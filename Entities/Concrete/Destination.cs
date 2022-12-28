using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Destination
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<DestinationImage> DestinationImages { get; set; }
        public ICollection<OtherDetails> OtherDetails { get; set; }
    }
}
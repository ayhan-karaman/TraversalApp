using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Contact
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
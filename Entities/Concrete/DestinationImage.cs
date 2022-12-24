using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DestinationImage
    {

        public int ID { get; set; }
        public int DestinationID { get; set; }
        public string PathName { get; set; }
        public bool Status { get; set; }
        public Destination Destination { get; set; }
    }
}
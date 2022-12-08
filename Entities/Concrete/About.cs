using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class About
    {
        public int ID { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string HeaderImage { get; set; }
        public string Title { get; set; }
        public string Details { get; set; } 
        public string TitleImage { get; set; }
        public bool Status { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comment
    {
        public int ID { get; set; }
        public int DestinationID { get; set; }
        public string CommentUser { get; set; }
        public DateTime CommentDate { get; set; }
        public string Content { get; set; }
        public bool State { get; set; }
        public Destination Destination { get; set; }
    }
}
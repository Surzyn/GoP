using System;
using System.Collections.Generic;
using System.Text;

namespace GoPDataAccess.Models
{
    public class Pub
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Street { get; set; }
        public double Rate { get; set; }
        public DateTime CreationDate { get; set; }

        public List<Image> Images { get; set; }
        public List<Comment> Comments { get; set; }
    }
}

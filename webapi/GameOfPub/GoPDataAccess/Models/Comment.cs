using System;
using System.Collections.Generic;

namespace GoPDataAccess.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public int Rate { get; set; }

        public List<Image> Images { get; set; }
    }
}

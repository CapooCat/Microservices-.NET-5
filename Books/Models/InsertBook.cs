using System;
using System.Collections.Generic;

#nullable disable

namespace Books.Models
{
    public partial class InsertBook
    {
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public double? Price { get; set; }
        public int AuthenId { get; set; }
        public string Img { get; set; }

    }
}

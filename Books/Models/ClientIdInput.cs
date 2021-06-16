using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models
{
    public partial class ClientIdInput
    {
        [Required]
        public int id { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public double? Price { get; set; }
        public string Img { get; set; }
    }
}

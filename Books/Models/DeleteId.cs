using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models
{
    public partial class DeleteId
    {
        [Required]
        public int id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Users.Models
{
    public partial class Book
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public double? Price { get; set; }
        public int AuthenId { get; set; }
        public string Img { get; set; }
        [JsonIgnore]
        public virtual User Authen { get; set; }
    }
}

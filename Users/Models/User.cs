using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Users.Models
{
    public partial class User
    {
        public User()
        {
            Books = new HashSet<Book>();
            UserPermissions = new HashSet<UserPermission>();
        }
        [JsonIgnore]
        public int Id { get; set; }
        public string Username { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public string Displayname { get; set; }
        [JsonIgnore]
        public string Token { get; set; }
        [JsonIgnore]
        public virtual ICollection<Book> Books { get; set; }
        [JsonIgnore]
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
}

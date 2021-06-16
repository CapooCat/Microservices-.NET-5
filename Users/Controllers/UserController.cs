using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Users.Models;

namespace Users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        BookShellContext db;

        public UserController()
        {
            db = new BookShellContext();
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.Users.ToList();
        }
    }
}

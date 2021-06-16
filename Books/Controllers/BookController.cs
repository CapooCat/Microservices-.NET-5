using Books.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        BookShellContext db;
        public BookController()
        {
            db = new BookShellContext();
        }
        //GET: api/Book
        [HttpGet]
        public IEnumerable<Book> GetBook()
        {
            return db.Books.ToList();
        }
        //POST: api/Book
        [HttpPost]
        public IActionResult Post([FromBody] Book Input)
        {
            try
            {
                db.Books.Add(Input);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, Input);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        //DELETE: api/Book
        [HttpDelete]
        public IActionResult Delete([FromBody] DeleteId Input)
        {
            try
            {
                Book book = db.Books.FirstOrDefault(x => x.Id == Input.id);
                if (book == null)
                    return StatusCode(StatusCodes.Status400BadRequest, Input);
                db.Books.Remove(book);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, Input);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        //PUT: api/Book
        [HttpPut]
        public IActionResult Put([FromBody] ClientIdInput Input)
        {
            try
            {
                Book book = db.Books.FirstOrDefault(x => x.Id == Input.id);
                if (book == null)
                    return StatusCode(StatusCodes.Status400BadRequest, Input);
                book.BookName = Input.BookName;
                book.BookAuthor = Input.BookAuthor;
                book.Price = Input.Price;
                book.Img = Input.Img;
                db.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, Input);
            } 
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }

        }
    }
}

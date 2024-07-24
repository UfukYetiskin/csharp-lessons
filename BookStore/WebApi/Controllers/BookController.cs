using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("books")]

    public class BookController : ControllerBase
    {
        private static readonly List<Book> books = new List<Book>
        {
            new Book(1, "The Great Gatsby", "F. Scott Fitzgerald", 1925, "Novel"),
            new Book(2, "To Kill a Mockingbird", "Harper Lee", 1960, "Novel"),
            new Book(3, "1984", "George Orwell", 1949, "Dystopian"),
            new Book(4, "Pride and Prejudice", "Jane Austen", 1813, "Novel")
        };

        [HttpGet("/")]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(books);
        }

        [HttpGet("/{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            var book = books.Find(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost("/")]
        public ActionResult AddBook(Book book)
        {
            if(book == null)
            {
                return BadRequest();
            }
            else{
                books.Add(book);
                return Ok();
            }
        }

        [HttpPut("/{id}")]
        public ActionResult UpdateBook(int id, Book book)
        {
            var bookToUpdate = books.Find(b => b.Id == id);

            if (bookToUpdate == null)
            {
                return NotFound();
            }

            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.Year = book.Year;
            bookToUpdate.Genre = book.Genre;

            return Ok();
        }

        [HttpDelete("/{id}")]
        public ActionResult DeleteBook(int id)
        {
            var bookToDelete = books.Find(b => b.Id == id);

            if (bookToDelete == null)
            {
                return NotFound();
            }

            books.Remove(bookToDelete);

            return Ok();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookStoreDbContext _context;
        public BookController(BookStoreDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            var books = _context.Books.ToList();
            if (books == null || !books.Any())
            {
                return NotFound("No books found."); // Geçici hata mesajı
            }

            return Ok(books);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            var book = _context.Books.SingleOrDefault(book => book.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            var existingBook = _context.Books.SingleOrDefault(x => x.Title == book.Title);
            if (existingBook != null)
            {
                return BadRequest("Book with the same Id already exists.");
            }

            _context.Books.Add(book);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateBook(int id, Book book)
        {
            var bookToUpdate = _context.Books.SingleOrDefault(x => x.Id == id);

            if (bookToUpdate == null)
            {
                return NotFound();
            }

            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.Year = book.Year;
            bookToUpdate.Genre = book.Genre;

            _context.SaveChanges();

            // Return the updated book
            return Ok(bookToUpdate);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteBook(int id)
        {
            var book = _context.Books.SingleOrDefault(x => x.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            _context.SaveChanges();

            return NoContent();
        }
    }
}

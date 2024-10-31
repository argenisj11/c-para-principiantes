using FirstApi.Data;
using FirstApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstApi.Controllers
{
    [ApiController]
    [Route("api/Controller")] //localhost:port/api/books
    public class BooksController : Controller
    {
        private readonly BooksDb _contex;
        public BooksController(BooksDb contex)
        {
            _contex = contex;
        }
        //Get =  api/books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _contex.Books.ToListAsync();
        }

        //Get = api/books/1
        [HttpGet("{id}")]
       public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _contex.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();

            }
            return book;
        }
        //Post =  api/books
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            _contex.Books.Add(book);
            await _contex.SaveChangesAsync();
            return CreatedAtAction("GetBook",new {id = book.Id}, book);

        }
        //Put =  api/books/2
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id,Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }
            var bookInDb = await _contex.Books.FindAsync(id);
            if (bookInDb == null)
            {
                return NotFound();

            }
            bookInDb.Title = book.Title;
            bookInDb.Author = book.Author;
            bookInDb.IsAvailale= book.IsAvailale;


            await _contex.SaveChangesAsync();
            return NoContent();
        }
        //Delete =  api/books/2
        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> DeleteBook(int id)
        {
            var bookInDb = await _contex.Books.FindAsync(id);
            if (bookInDb == null)
            {
                return NotFound();

            }
            _contex.Books.Remove(bookInDb);
            await _contex.SaveChangesAsync();
            return NoContent();
        }
    }
}

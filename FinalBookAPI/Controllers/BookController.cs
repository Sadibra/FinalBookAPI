using FinalBookAPI.DTO;
using FinalBookAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinalBookAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            this._bookService = bookService;
        }

        [HttpGet("{id}")]

        public IActionResult GetBookById(int id)
        {
            var book = _bookService.getBookById(id);
            return Ok(book);
        }

        [HttpGet]

        public IActionResult GetAllBooks()
        {
            var books = _bookService.getAllBooks();
            return Ok(books);
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteBook(int id)
        {
            _bookService.deleteBook(id);
            return NoContent();
        }

        [HttpPost]

        public IActionResult CreateBook(BookDTO newBook)
        {
            var book = _bookService.createBook(newBook);
            return Ok(book);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, BookDTO updatedBook)
        {
            var isUpdated = _bookService.updateBook(id, updatedBook);

            if (isUpdated)
            {
                return Ok(updatedBook);
            }
            else
            {
                return NotFound();
            }
        }
    }
}


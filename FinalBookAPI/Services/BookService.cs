using FinalBookAPI.DTO;
using FinalBookAPI.Models;

namespace FinalBookAPI.Services
{
    public class BookService : IBookService
    {
        private KitabBaza2Context _context;
        public BookService(KitabBaza2Context context)
        {
            this._context = context;
        }
        public BookDTO createBook(BookDTO newBook)
        {
            var book = new Kitab { Ad = newBook.Ad, Say = newBook.Say, Qiymet = newBook.Qiymet };
            _context.Kitabs.Add(book);
            _context.SaveChanges();
            return newBook;
        }

        public bool deleteBook(int id)
        {
            var book = _context.Kitabs.Find(id);
            if (book != null)
            {
                _context.Kitabs.Remove(book);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            


        }

        public IEnumerable<BookDTO> getAllBooks()
        {
            return _context.Kitabs.Select(book => new BookDTO { Ad = book.Ad, Say = book.Say, Qiymet = book.Qiymet });
        }

        public BookDTO getBookById(int id)
        {
            var book = _context.Kitabs.Find(id);
            if (book == null)
            {
                return null;
            }
            else
            {
                return new BookDTO { Id = book.Id, Ad = book.Ad, Qiymet = book.Qiymet, Say = book.Say };

            }
        }
        public bool updateBook(int id, BookDTO book)
        {
            var book1 = _context.Kitabs.Find(id);
            if(book != null)
            {
                book1.Ad = book.Ad;
                book1.Say = book.Say;
                book1.Qiymet = book.Qiymet;
                _context.SaveChanges(); 
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

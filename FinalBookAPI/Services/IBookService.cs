using FinalBookAPI.DTO;

namespace FinalBookAPI.Services
{
    public interface IBookService
    {
        BookDTO getBookById(int id);
        IEnumerable<BookDTO> getAllBooks();
        BookDTO createBook(BookDTO newBook);
        bool deleteBook(int id);
        bool updateBook(int id, BookDTO book);
    }
}

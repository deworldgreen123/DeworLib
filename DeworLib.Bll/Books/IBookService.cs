using DeworLib.Bll.Books.Data;
using DeworLib.Dal.Models;

namespace DeworLib.Bll.Books;

public interface IBookService
{
    Task<Book> CreateBook(CreateBookData bookData);
    Task<Book> GetById(Guid idBook);
}
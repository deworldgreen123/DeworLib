using DeworLib.Bll.Books.Data;
using DeworLib.Dal.Models;
using DeworLib.Dal.Repositories;

namespace DeworLib.Bll.Books;

public class BookService : IBookService
{
    private readonly IBaseRepository<Book> _bookRepository;
    
    public Task<Book> CreateBook(CreateBookData bookData)
    {
        var book = new Book()
        {
            Id = Guid.NewGuid(),
            Title = bookData.Title,
            Description = bookData.Description
        };
        _bookRepository.Create(book);
        throw new NotImplementedException();
    }

    public Task<Book> GetById(Guid idBook)
    {
        throw new NotImplementedException();
    }
}
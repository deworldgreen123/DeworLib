using DeworLib.Bll.Books;
using DeworLib.Bll.Books.Data;
using DeworLib.Controllers.Books.Dto;
using DeworLib.Dal.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeworLib.Controllers.Books;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;
    
    [HttpPost]
    public async Task<ActionResult<Book>> CreateBook([FromBody]CreateBookRequestDto bookDto)
    {
        if (bookDto.AuthorIds.Length == 0) return BadRequest();
        
        var result = await _bookService.CreateBook(new CreateBookData()
        {
            Id = Guid.NewGuid(),
            Title = bookDto.Title,
            Description = bookDto.Description,
            AuthorIds = bookDto.AuthorIds,
        });
        
        if (result is null) return BadRequest();
        
        return result;
    }
    
    [HttpGet("/{bookId:guid}")]
    public async Task<ActionResult<Book>> GetBook(Guid bookId)
    {
        var result = await _bookService.GetById(bookId);
        if (result is null)
            return BadRequest();
        return result;
    }
}
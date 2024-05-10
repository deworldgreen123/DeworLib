using DeworLib.Bll.Authors;
using DeworLib.Controllers.Authors.Dto;
using DeworLib.Dal.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeworLib.Controllers.Authors;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase
{
    private readonly IAuthorService _authorService;
    
    [HttpPost]
    public async Task<ActionResult<Author>> CreateAuthor([FromBody]CreateAuthorRequestDto authorDto)
    {
        throw new NotImplementedException();
    }
    
    [HttpGet("/{bookId:guid}")]
    public async Task<ActionResult<Author>> GetAuthor(Guid authorId)
    {
        throw new NotImplementedException();
    }
}
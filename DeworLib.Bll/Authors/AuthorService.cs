using DeworLib.Bll.Authors.Data;
using DeworLib.Dal.Models;

namespace DeworLib.Bll.Authors;

public class AuthorService : IAuthorService
{
    public Task<Author> CreateAuthor(CreateAuthorData authorData)
    {
        throw new NotImplementedException();
    }

    public Task<Author> GetById(Guid idAuthor)
    {
        throw new NotImplementedException();
    }
}
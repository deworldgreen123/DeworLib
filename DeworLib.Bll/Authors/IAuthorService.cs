using DeworLib.Bll.Authors.Data;
using DeworLib.Dal.Models;

namespace DeworLib.Bll.Authors;

public interface IAuthorService
{
    Task<Author> CreateAuthor(CreateAuthorData authorData);
    Task<Author> GetById(Guid idAuthor);
}
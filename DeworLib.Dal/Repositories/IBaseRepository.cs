using DeworLib.Dal.Models;

namespace DeworLib.Dal.Repositories;

public interface IBaseRepository<TDbModel> where TDbModel : BaseModel
{
    public Task<IEnumerable<TDbModel>> GetAll();
    public Task<TDbModel> GetById(Guid id);
    public Task<TDbModel> Create(TDbModel model);
    public Task<TDbModel> Update(TDbModel model);
    public Task Delete(Guid id);
}
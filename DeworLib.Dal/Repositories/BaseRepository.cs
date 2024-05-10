using DeworLib.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace DeworLib.Dal.Repositories;

public class BaseRepository<TDbModel>(DbContext context) : IBaseRepository<TDbModel> where TDbModel : BaseModel
{
    public async Task<IEnumerable<TDbModel>> GetAll()
    {
        return await context.Set<TDbModel>().ToListAsync();
    }

    public async Task<TDbModel> GetById(Guid id)
    {
        var res = await context.Set<TDbModel>().FirstOrDefaultAsync(m => m.Id == id);
        if (res is null) throw new Exception("Не существует модель с типом" + typeof(TDbModel) + "и c Id" + id);
        return res;
    }

    public async Task<TDbModel> Create(TDbModel model)
    {
        await context.Set<TDbModel>().AddAsync(model);
        await context.SaveChangesAsync();
        return model;
    }

    public async Task<TDbModel> Update(TDbModel model)
    {
        await GetById(model.Id);
        context.Update(model);
        await context.SaveChangesAsync();
        return model;
    }

    public async Task Delete(Guid id)
    {
        var toDelete = await GetById(id);
        context.Set<TDbModel>().Remove(toDelete);
        await context.SaveChangesAsync();
    }
}
using TeslaShop.Data.IRepositories;
using TeslaShop.Domain.Commons;

namespace TeslaShop.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
{
    public Task<bool> DeleteAsync(long id)
    {
        
    }

    public Task<TEntity> InsertAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> SelectAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> SelectByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
} 


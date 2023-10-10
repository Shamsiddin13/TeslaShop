using Microsoft.EntityFrameworkCore;
using TeslaShop.Data.DbContexts;
using TeslaShop.Data.IRepositories;
using TeslaShop.Domain.Commons;

namespace TeslaShop.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
{
    AppDbContext dbContext;
    DbSet<TEntity> dbSet;

    public Repository()
    {
        dbContext = new AppDbContext();
        dbSet = dbContext.Set<TEntity>();
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var entity = await dbSet.FirstOrDefaultAsync(e => e.Id == id);
        dbSet.Remove(entity);
        await dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        await dbSet.AddAsync(entity);
        await dbContext.SaveChangesAsync();
        return entity;
    }

    public IQueryable<TEntity> SelectAllAsync()
        => this.dbSet;


    public async Task<TEntity> SelectByIdAsync(long id)
        => await dbSet.FirstOrDefaultAsync(e => e.Id == id);


    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        var model = (dbContext.Update(entity)).Entity;
        await dbContext.SaveChangesAsync();
        return model;

    }
} 


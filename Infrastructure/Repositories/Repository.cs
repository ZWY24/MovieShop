using ApplicationCore.Contracts.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly MovieShopDbContext _dbContext;
    private readonly DbSet<T> _dbSet;

    public Repository(MovieShopDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }

    public virtual T GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public virtual IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public virtual T Add(T entity)
    {
        _dbSet.Add(entity);
        _dbContext.SaveChanges();
        return entity;
    }

    public virtual T Update(T entity)
    {
        _dbSet.Update(entity);
        _dbContext.SaveChanges();
        return entity;
    }

    public virtual T Delete(T entity)
    {
        _dbSet.Remove(entity);
        _dbContext.SaveChanges();
        return entity;
    }
}
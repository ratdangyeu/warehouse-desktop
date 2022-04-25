using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;

namespace Warehouse.Repository
{
    public interface IUnitOfWork
    {
        IRepository<T> Repository<T>() where T : class;
        void SaveChangesAsync();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;
        private Hashtable _repositories;

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<T> Repository<T>() where T : class
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Repository<>);

                var repositoryInstance =
                    Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _dbContext);

                _repositories.Add(type, repositoryInstance);
            }

            return (IRepository<T>)_repositories[type];
        }

        public void SaveChangesAsync()
        {
            _dbContext.SaveChanges();
        }
    }

    public interface IRepository<TEntity> where TEntity : class
    {
        void InsertAsync(TEntity entity);
    }

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _dbContext;
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void InsertAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().AddAsync(entity);
        }
    }
}

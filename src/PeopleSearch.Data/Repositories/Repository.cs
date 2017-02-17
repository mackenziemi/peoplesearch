using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using PeopleSearch.Data.Interfaces;

namespace PeopleSearch.Data.Repositories
{
    /// <summary>
    /// Abstract Parent Class for all Repositories
    /// </summary>
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity: class
    {
        #region Properites/Members

        protected DbContext Context;
        private DbSet<TEntity> _dbSet;


        public int Count => _dbSet.Count();

        #endregion


        #region Constructors

        public Repository()
        {
            Context =new PeopleSearchContext();
            _dbSet = Context.Set<TEntity>();
        }

        public Repository(DbContext context)
        {
            Context = context;
            _dbSet = Context.Set<TEntity>();
        }

        #endregion


        public void Create(TEntity t)
        {
            _dbSet.Add(t);
        }

        public void Delete(TEntity t)
        {
            _dbSet.Remove(t);
        }

        public void Dispose()
        {
           Context.Dispose();
        }

        public IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsQueryable();
        }

        public TEntity FindById(object key)
        {
            return _dbSet.Find(key);
        }

        public IQueryable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().AsQueryable();
        }

        public void Update(TEntity t)
        {
            Context.Entry(t).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
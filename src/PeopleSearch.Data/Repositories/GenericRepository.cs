using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;
using PeopleSearch.Data.Interfaces;

namespace PeopleSearch.Data.Repositories
{
    /// <summary>
    /// Abstract Parent Class for all Repositories
    /// </summary>
    public class GenericRepository<TEntity> : IRepository<TEntity>
        where TEntity: class
    {
        #region Properites/Members

        protected DbContext Context;
        private DbSet<TEntity> dbSet;


        public int Count => dbSet.Count();

        #endregion

        #region Constructors

        public GenericRepository(DbContext context)
        {
            Context = context;
            dbSet = Context.Set<TEntity>();
        }

        #endregion

        public void Create(TEntity t)
        {
            dbSet.Add(t);
        }

        public void Delete( int key)
        {
            var existing = Context.Set<TEntity>().Find(key);
            if (existing == null) return;
            dbSet.Remove(existing);
            SaveChanges();
        }

        public void Dispose()
        {
           Context.Dispose();
        }

        public IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate).AsQueryable();
        }

        public TEntity FindById(object key)
        {
            return dbSet.Find(key);
        }

        public IQueryable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().AsQueryable();
        }

        public void Update(TEntity t, int key)
        {
            if (t == null)
                return;

            var existing = Context.Set<TEntity>().Find(key);
            if (existing == null) return;
            Context.Entry(existing).CurrentValues.SetValues(t);
            SaveChanges();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
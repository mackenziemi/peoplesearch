using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PeopleSearch.Data.Interfaces
{
    /// <summary>
    /// Interface contract for a data repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>:IDisposable
    {
        /// <summary>
        /// This method will return all the results of the repository
        /// </summary>
        /// <returns>returns an IQueryable of the Type of the repository</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// This method will return a set of results based on the evaluation of the predicate against the data in the repository
        /// </summary>
        /// <param name="predicate">the filter used against the data</param>
        /// <returns>return an IQueryable of the Type of the resository</returns>
        IQueryable<T> Filter(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Finds and returns a set of objects based on their Id
        /// </summary>
        /// <param name="keys">and int Id to search for</param>
        /// <returns>returns an object based on its Id</returns>
        T FindById(object key);

        /// <summary>
        /// Method for adding/creating an entity
        /// </summary>
        /// <param name="t">the object that is being added to the repository</param>
        /// <returns></returns>
        void Create(T t);

        /// <summary>
        /// Updates an object to the repository
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        void Update(T t);

        /// <summary>
        /// Deletes an object from the repository
        /// </summary>
        /// <param name="t">the object to delete</param>
        /// <returns></returns>
        void Delete(T t);

        /// <summary>
        /// The number of objects in the repository
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Save changes
        /// </summary>
        void SaveChanges();
    }
}
using System;
using PeopleSearch.Data.Entities;
using PeopleSearch.Data.Repositories;

namespace PeopleSearch.Data.Interfaces
{
    /// <summary>
    /// Interface for the PeopleSearch Unit of Work
    /// </summary>
    public interface IPeopleSearchUnitOfWork:IDisposable
    {
        /// <summary>
        /// GenericRepository for the Person Entity
        /// </summary>
       GenericRepository<PersonEntity> PeopleRepository { get; }

        /// <summary>
        /// Saves/Updates the database
        /// </summary>
        void Save();
    }
}
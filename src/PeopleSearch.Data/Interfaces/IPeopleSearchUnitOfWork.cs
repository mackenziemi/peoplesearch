using PeopleSearch.Data.Repositories;

namespace PeopleSearch.Data.Interfaces
{
    /// <summary>
    /// Interface for the PeopleSearch Unit of Work
    /// </summary>
    public interface IPeopleSearchUnitOfWork
    {
        /// <summary>
        /// Repository for the Person Entity
        /// </summary>
       PeopleRepository PeopleRepository { get; }

        /// <summary>
        /// Saves/Updates the database
        /// </summary>
        void Save();
    }
}
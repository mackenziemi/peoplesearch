namespace PeopleSearch.Data.Interfaces
{
    /// <summary>
    /// Interface for a Person Entity
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// The db primary key for this entity
        /// </summary>
        int Id { get; }

        /// <summary>
        /// First Name of the Person
        /// </summary>
        string FirstName { get; }

        /// <summary>
        /// Last Name of the Person
        /// </summary>
        string LastName { get; }
    }
}
namespace PeopleSearch.Logic.Interfaces
{
    /// <summary>
    /// Interface to a Person Entity
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// The integer Id to the Person in question
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
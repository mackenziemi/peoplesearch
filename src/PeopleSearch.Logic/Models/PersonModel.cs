using PeopleSearch.Logic.Interfaces;

namespace PeopleSearch.Logic.Models
{
    public class PersonModel : IPerson
    {
        #region Properties/Members

        public int Id { get; set; } = -1;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        #endregion

        #region Constructors

        public PersonModel()
        {
            
        }

        public PersonModel(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        #endregion
    }
}
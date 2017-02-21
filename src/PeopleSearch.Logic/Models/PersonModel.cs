using PeopleSearch.Logic.Interfaces;

namespace PeopleSearch.Logic.Models
{
    public class PersonModel : IPerson
    {
        #region Properties/Members

        public int Id { get; set; } = -1;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public int Age { get; set; } = 0;

        public string Interests { get; set; }

        public string PictureURI { get; set; }

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
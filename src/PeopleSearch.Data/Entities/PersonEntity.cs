using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PeopleSearch.Data.Interfaces;

namespace PeopleSearch.Data.Entities
{
    /// <summary>
    /// Person Entity
    /// </summary>
    public class PersonEntity:IPerson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
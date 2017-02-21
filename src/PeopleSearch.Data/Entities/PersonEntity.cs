using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PeopleSearch.Data.Interfaces;

namespace PeopleSearch.Data.Entities
{
    /// <summary>
    /// Person Entity
    /// </summary>
    [Table("People")]
    public class PersonEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(20)]
        public string State { get; set; }
        [MaxLength(9)]
        public string ZipCode { get; set; }

        public int Age { get; set; } = 0;

        public string Interests { get; set; }

        public string PictureURI { get; set; }
    }
}
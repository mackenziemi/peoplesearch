using PeopleSearch.Data.Interfaces;
using System.Data.Entity;
using PeopleSearch.Data.Entities;

namespace PeopleSearch.Data
{
    public class PeopleSearchContext:DbContext
    {
        #region Properties/Members

        public DbSet<PersonEntity> People { get; set; }

        #endregion

        #region Constructors

        public PeopleSearchContext()
            : base("name=dbconnection")
        {
            
        }

        #endregion
    }
}
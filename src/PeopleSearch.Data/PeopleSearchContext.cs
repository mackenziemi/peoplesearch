using PeopleSearch.Data.Interfaces;
using System.Data.Entity;

namespace PeopleSearch.Data
{
    public class PeopleSearchContext:DbContext
    {
        #region Properties/Members

        public DbSet<IPerson> People { get; set; }

        #endregion

        #region Constructors

        public PeopleSearchContext()
            : base("dbconnection")
        {
            
        }

        #endregion
    }
}
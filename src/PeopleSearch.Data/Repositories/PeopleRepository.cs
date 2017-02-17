using PeopleSearch.Data.Entities;

namespace PeopleSearch.Data.Repositories
{
    public class PeopleRepository:Repository<PersonEntity>
    {
        public PeopleRepository()
            :base()
        {
            
        }
    }
}
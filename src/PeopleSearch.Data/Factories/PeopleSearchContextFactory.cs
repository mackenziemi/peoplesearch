using PeopleSearch.Data.Interfaces;

namespace PeopleSearch.Data.Factories
{
    public class PeopleSearchContextFactory:IDbContextFactory<PeopleSearchContext>
    {
        public PeopleSearchContext NewDbContext()
        {
            return new PeopleSearchContext();
        }
    }
}
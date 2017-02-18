namespace PeopleSearch.Data.Interfaces
{
    public interface IDbContextFactory<out T>
    {
        T NewDbContext();
    }
}
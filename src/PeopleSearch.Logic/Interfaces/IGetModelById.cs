using System.Collections;

namespace PeopleSearch.Logic.Interfaces
{
    public interface IGetModelById<T>
    {
        T GetModelById(int id);
    }
}
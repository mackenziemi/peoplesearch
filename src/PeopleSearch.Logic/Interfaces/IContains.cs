using System.Collections.Generic;

namespace PeopleSearch.Logic.Interfaces
{
    public interface IContains<T>
    {

        IList<T> Contains(string filter);
    }
}
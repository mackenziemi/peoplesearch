using System.Collections.Generic;

namespace PeopleSearch.Logic.Interfaces
{
    public interface IGetAllModels<T>
    {
        IList<T> GetAll();
    }
}
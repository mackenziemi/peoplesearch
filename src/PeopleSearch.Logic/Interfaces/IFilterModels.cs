using System;
using System.Linq;
using System.Linq.Expressions;

namespace PeopleSearch.Logic.Interfaces
{
    public interface IFilterModels<T>
    {
        IQueryable<T> FilterModels(Expression<Func<T, bool>> predicate);
    }
}
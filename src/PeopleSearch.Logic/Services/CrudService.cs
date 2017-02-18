using PeopleSearch.Data;
using PeopleSearch.Data.Interfaces;
using PeopleSearch.Logic.Interfaces;

namespace PeopleSearch.Logic.Services
{
    public abstract class CrudService<T>: ICrudService<T>
    {
        #region Properties/Membersd

        protected IPeopleSearchUnitOfWork UnitOfWork;

        #endregion

        #region Constructors

        protected CrudService()
        {
            UnitOfWork = new PeopleSearchUnitOfWork();
        }

        #endregion


        #region Methods

        public abstract void InsertModel(T model);

        public abstract T GetModelById(int id);

        public abstract void UpdateModel(T model);

        public abstract void DeleteModel(T model);

        #endregion


    }
}
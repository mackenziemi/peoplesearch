using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using PeopleSearch.Data;
using PeopleSearch.Data.Interfaces;
using PeopleSearch.Logic.Interfaces;

namespace PeopleSearch.Logic.Services
{
    public abstract class CrudService<T>: ICrudService<T>
    {
        #region Properties/Members

        protected IDbContextFactory<DbContext> ContextFactory { get; private set; }

        protected IPeopleSearchUnitOfWork UnitOfWork;

        #endregion

        #region Constructors

        protected CrudService(IDbContextFactory<DbContext> factory)
        {
            ContextFactory = factory;

            UnitOfWork = new PeopleSearchUnitOfWork((PeopleSearchContext)ContextFactory.NewDbContext());
        }

        #endregion


        #region Methods

        public abstract void InsertModel(T model);

        public abstract T GetModelById(int id);

        public abstract void UpdateModel(T model);

        public abstract void DeleteModel(T model);

        public abstract IList<T> GetAll();

        public abstract IList<T> Contains(string filter);

        #endregion


    }
}
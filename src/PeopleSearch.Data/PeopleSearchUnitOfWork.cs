using System;
using System.Data.Entity;
using PeopleSearch.Data.Entities;
using PeopleSearch.Data.Interfaces;
using PeopleSearch.Data.Repositories;

namespace PeopleSearch.Data
{
    public class PeopleSearchUnitOfWork:IPeopleSearchUnitOfWork
    {
        #region Properties/Members

        private PeopleSearchContext Context;


        private GenericRepository<PersonEntity> peopleRepository;
        public GenericRepository<PersonEntity> PeopleRepository
        {
            get
            {
                if (peopleRepository == null)
                {
                    this.peopleRepository=new GenericRepository<PersonEntity>(Context);
                }
                return peopleRepository;
            } 
        }

        #endregion

        #region Constructors

        public PeopleSearchUnitOfWork()
        {
            Context = new PeopleSearchContext();
        }

        public PeopleSearchUnitOfWork(PeopleSearchContext context)
        {
            this.Context = context;
        }

        #endregion


        #region Methods

        public void Save()
        {
            Context.SaveChanges();
        }


        public void Dispose()
        {
            peopleRepository.Dispose();
        }

        #endregion
    }
}
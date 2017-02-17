using System;
using System.Data.Entity;
using PeopleSearch.Data.Interfaces;
using PeopleSearch.Data.Repositories;

namespace PeopleSearch.Data
{
    public class PeopleSearchUnitOfWork:IPeopleSearchUnitOfWork
    {
        #region Properties/Members

        private PeopleRepository _peopleRepository;
        public PeopleRepository PeopleRepository
        {
            get
            {
                if (_peopleRepository == null)
                {
                    this._peopleRepository=new PeopleRepository();
                }
                return _peopleRepository;
            } 
        }

        

        #endregion

        #region Methods

        public void Save()
        {
            throw new System.NotImplementedException();
        }


        public void Dispose()
        {
            _peopleRepository.Dispose();
        }
        #endregion
    }
}
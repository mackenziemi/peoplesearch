using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using PeopleSearch.Data.Entities;
using PeopleSearch.Data.Interfaces;
using PeopleSearch.Logic.Interfaces;
using PeopleSearch.Logic.Models;

namespace PeopleSearch.Logic.Services
{
    public class PeopleService : CrudService<PersonModel>
    {

        #region Constructors

        public PeopleService(IDbContextFactory<DbContext> factory)
            : base(factory)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<PersonEntity, PersonModel>();
                cfg.CreateMap<PersonModel, PersonEntity>();
            });
        }

        #endregion

        #region Methods

        public override void InsertModel(PersonModel model)
        {
            PersonEntity entity = Mapper.Map<PersonEntity>(model);
            UnitOfWork.PeopleRepository.Create(entity);
            UnitOfWork.Save();
        }

        public override PersonModel GetModelById(int id)
        {
            var entity = UnitOfWork.PeopleRepository.FindById(id);
            var model = Mapper.Map<PersonModel>(entity);
            return model;
        }

        public override void UpdateModel(PersonModel model)
        {
            PersonEntity entity = Mapper.Map<PersonEntity>(model);
            UnitOfWork.PeopleRepository.Update(entity, entity.Id);
            UnitOfWork.Save();
        }

        public override void DeleteModel(PersonModel model)
        {
            UnitOfWork.PeopleRepository.Delete(model.Id);
            UnitOfWork.Save();
        }

        public override IList<PersonModel> GetAll()
        {
            var entities = UnitOfWork.PeopleRepository.GetAll();
            var result = new List<PersonModel>();
            entities.ToList().ForEach(e=>result.Add(Mapper.Map<PersonModel>(e)));
            return result;
        }

        public override IList<PersonModel> Contains(string filter)
        {
            var results = new List<PersonModel>();
            var data =
                UnitOfWork.PeopleRepository.Filter(x => x.FirstName.Contains(filter) || x.LastName.Contains(filter));
            data.ToList().ForEach(i => results.Add(Mapper.Map<PersonModel>(i)));
            return results;
        }
        #endregion


    }
}
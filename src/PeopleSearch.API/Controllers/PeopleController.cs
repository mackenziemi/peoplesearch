using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Practices.Unity;
using PeopleSearch.Data;
using PeopleSearch.Data.Factories;
using PeopleSearch.Logic.Interfaces;
using PeopleSearch.Logic.Models;
using PeopleSearch.Logic.Services;
using PeopleSearch.Data.Interfaces;

namespace PeopleSearch.API.Controllers
{
    public class PeopleController : ApiController
    {
        #region Properties/Members 

        private UnityContainer unityContainer;
        private ICrudService<PersonModel> service;

        #endregion

        #region Constructors

        public PeopleController()
        {
            unityContainer = new UnityContainer();

            unityContainer.RegisterType<IDbContextFactory<DbContext>, PeopleSearchContextFactory>();
            unityContainer.RegisterType<ICrudService<PersonModel>, PeopleService>();

            service = unityContainer.Resolve<ICrudService<PersonModel>>();
        }

        #endregion

        // GET api/<controller>
        public IEnumerable<PersonModel> Get()
        {
            return service.GetAll().AsEnumerable();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
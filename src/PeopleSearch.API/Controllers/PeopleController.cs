using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
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
        [System.Web.Http.HttpGet]
        public IEnumerable<PersonModel> Get(string filter)
        {
            if (!string.IsNullOrEmpty(filter))
            {
                return service.Contains(filter).AsEnumerable();
            }
            else
            {
                return service.GetAll().AsEnumerable();
            }
            
        }

        // GET api/<controller>/5
        public PersonModel Get(int id)
        {
            return service.GetModelById(id);
        }

        // POST api/<controller>
        public ActionResult Post([FromBody]PersonModel value)
        {
            service.InsertModel(value);
            return new HttpStatusCodeResult(HttpStatusCode.OK);  // OK = 200
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
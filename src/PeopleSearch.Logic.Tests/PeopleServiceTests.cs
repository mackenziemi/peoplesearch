using NUnit.Framework;
using PeopleSearch.Data.Interfaces;
using System.Data.Entity;
using System.Linq;
using PeopleSearch.Data;
using PeopleSearch.Data.Entities;
using PeopleSearch.Data.Factories;
using PeopleSearch.Logic.Interfaces;
using PeopleSearch.Logic.Models;
using PeopleSearch.Logic.Services;

namespace PeopleSearch.Logic.Tests
{
    /// <summary>
    /// This is an integration test to test the PeopleService class
    /// </summary>
    [TestFixture]
    public class PeopleServiceTests
    {
        #region Properties/Members

        private IDbContextFactory<DbContext> contextFactory;
        private ICrudService<PersonModel> service;

        #endregion


        #region Setup & TearDown

        [OneTimeSetUp]
        public void FixtureSetup()
        {
            // Initialize the objects
            contextFactory = new PeopleSearchContextFactory();
            service = new PeopleService(contextFactory);
        }

        [OneTimeTearDown]
        public void FixtureTearDown()
        {

        }

        #endregion

        [Test]
        public void PeopleServiceCrudTest()
        {
            // ARRANGE
            var model = new PersonModel {FirstName = "Phil", LastName="Collson"};

            // Create & Read
            service.InsertModel(model);
            var read = service.GetAll().FirstOrDefault(m => m.FirstName == "Phil" && m.LastName == "Collson");
            Assert.IsNotNull(read);

            model.Id = read.Id;
            model.LastName = "Coulson";
            service.UpdateModel(model);
            var read2 = service.GetAll().FirstOrDefault(m => m.FirstName == "Phil" && m.LastName == "Coulson");
            Assert.IsNotNull(read2);

            service.DeleteModel(read);
            var read3 = service.GetAll().FirstOrDefault(m => m.FirstName == "Phil" && m.LastName == "Coulson");
            Assert.IsNull(read3);
        }

    }
}
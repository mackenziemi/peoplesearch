using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PeopleSearch.Data;
using PeopleSearch.Data.Entities;

namespace PeopleSearch.Data.Tests
{
    /// <summary>
    /// This is an integration test to test the functionality of the People Search Unit of Work
    /// </summary>
    [TestFixture]
    class PeopleSearchUnitOfWorkTest
    {
        #region Properties/Members

        private PeopleSearchContext dbContext;
        private PeopleSearchUnitOfWork unitOfWork;
        private PeopleSearchDbInitializer dbInitializer;


        #endregion

        #region Setup & TearDown

        [OneTimeSetUp]
        public void FixtureSetup()
        {
            // Initialize the objects
            dbContext = new PeopleSearchContext();
            unitOfWork = new PeopleSearchUnitOfWork(dbContext);
            dbInitializer = new PeopleSearchDbInitializer();

            // Make sure the database is initialized and seeded
            Database.SetInitializer(dbInitializer);
            dbContext.Database.Initialize(false);

        }

        [OneTimeTearDown]
        public void FixtureTearDown()
        {

        }

        #endregion

        #region Tests

        [Test]
        public void PeopleRepositoryCRUDTest()
        {
            //ARRANGE
            var person = new PersonEntity {FirstName = "Phil", LastName = "Collson"};

            // Create
            unitOfWork.PeopleRepository.Create(person);
            unitOfWork.Save();

            //dbContext.Set<PersonEntity>().Add(person);
            //dbContext.SaveChanges();
            Assert.That(unitOfWork.PeopleRepository.GetAll().Any(x=>x.FirstName=="Phil" && x.LastName=="Collson"));

            // Read
            var readPerson =
                unitOfWork.PeopleRepository.GetAll()
                    .FirstOrDefault(x => x.FirstName == "Phil" && x.LastName == "Collson");
            Assert.That(readPerson!=null);

            // Update
            person.LastName = "Coulson";
            unitOfWork.PeopleRepository.Update(person);
            unitOfWork.Save();
            Assert.That(unitOfWork.PeopleRepository.GetAll().Any(x => x.FirstName == "Phil" && x.LastName == "Coulson"));

            // Delete
            unitOfWork.PeopleRepository.Delete(person);
            unitOfWork.Save();
            Assert.That(!unitOfWork.PeopleRepository.GetAll().Any(x => x.FirstName == "Phil" && x.LastName == "Coulson"));
        }

        #endregion


    }
}

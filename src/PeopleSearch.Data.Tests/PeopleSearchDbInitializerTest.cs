using System.Data.Entity;
using NUnit.Framework;
using NUnit.Framework.Internal;
using PeopleSearch.Data.Factories;
using PeopleSearch.Data.Interfaces;

namespace PeopleSearch.Data.Tests
{
    [TestFixture]
    public class PeopleSearchDbInitializerTest
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
            IDbContextFactory<PeopleSearchContext> contextFactory = new PeopleSearchContextFactory();
            dbContext = contextFactory.NewDbContext();
            unitOfWork = new PeopleSearchUnitOfWork(dbContext);
            dbInitializer = new PeopleSearchDbInitializer();
        }

        [OneTimeTearDown]
        public void FixtureTearDown()
        {
            
        }

        #endregion

        #region Tests

        [Test]
        public void PeopleSearchDbInitializerSeedTest()
        {

            //ARANGE
            Database.SetInitializer(dbInitializer);

            //ACT
            dbContext.Database.Initialize(false);

            //ASSERT
            Assert.That(unitOfWork.PeopleRepository.Count>0);
        }

        #endregion
    }
}
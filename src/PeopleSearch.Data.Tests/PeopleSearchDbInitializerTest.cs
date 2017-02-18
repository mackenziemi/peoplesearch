using System.Data.Entity;
using NUnit.Framework;
using NUnit.Framework.Internal;

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
            dbContext=new PeopleSearchContext();
            unitOfWork=new PeopleSearchUnitOfWork();
            dbInitializer=new PeopleSearchDbInitializer();
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
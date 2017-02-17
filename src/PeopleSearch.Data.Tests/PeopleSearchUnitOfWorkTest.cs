using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PeopleSearch.Data;

namespace PeopleSearch.Data.Tests
{
    [TestFixture]
    class PeopleSearchUnitOfWorkTest
    {
        private PeopleSearchUnitOfWork unitOfWork;


        [OneTimeSetUp]
        public void FixtureSetup()
        {
            unitOfWork=new PeopleSearchUnitOfWork();
        }


    }
}

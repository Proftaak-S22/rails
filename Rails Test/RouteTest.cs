using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTRails.DAL;
using CTRails.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rails_Test
{
    [TestClass]
    public class RouteTest
    {
        private UnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            unitOfWork = new UnitOfWork(true);
        }

        [TestMethod]
        public void InsertRoute()
        {
            Route route = new Route(8,"Route naar hemel");
            unitOfWork.Routes.Add(route);
            Assert.AreEqual(route, unitOfWork.Routes.Where(x => x.Name == "Route naar hemel"));
        }

        [TestCleanup]
        public void CleanUp()
        {
            unitOfWork = null;
        }
    }
}

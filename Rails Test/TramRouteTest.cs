using System;
using System.Linq;
using CTRails;
using CTRails.DAL;
using CTRails.Entities;
using CTRails.Entities.Employees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rails_Test
{
    [TestClass]
    public class TramRouteTest
    {
        private UnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            unitOfWork = new UnitOfWork(true);
        }

        [TestMethod]
        public void InsertTramRoute()
        { 
            TramRoute tramRoute =new TramRoute(1, unitOfWork.Trams.Where(x => x.Code == 2001).First(), unitOfWork.Routes.Where(x => x.ID == 1).First());
            unitOfWork.TramRoutes.Add(tramRoute);
            Assert.AreEqual(tramRoute, unitOfWork.TramRoutes.Where(x => x.ID == 1).First());
        }

        [TestCleanup]
        public void CleanUp()
        {
            unitOfWork = null;
        }
    }
}

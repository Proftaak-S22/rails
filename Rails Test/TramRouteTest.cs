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
            //TramRoute tramRoute = new TramRoute(1, unitOfWork.Trams.Where(x => x.Code == 1023).First(), unitOfWork.Routes.Where(x => x.ID == 1).First());
            //unitOfWork.TramRoutes.Add(tramRoute);
            //Assert.AreEqual(tramRoute.ID, unitOfWork.TramRoutes.Where(x => x.ID == 1).First().ID);
        }

        [TestCleanup]
        public void CleanUp()
        {
            unitOfWork = null;
        }
    }
}

using System;
using System.Linq;
using CTRails.DAL;
using CTRails.Entities;
using CTRails.Entities.Employees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rails_Test
{
    [TestClass]
    public class TrackRouteDataTest
    {

        private UnitOfWork work;

        [TestInitialize]
        public void Initialize()
        {
            work = new UnitOfWork(true);
        }


        [TestCleanup]
        public void Clean()
        {
            work = null;
        }

        [TestMethod]
        public void TrackRouteRetrieve()
        {

            //TrackRoute t = new TrackRoute(2, new Track(2), new Route(2, "B"));



            Assert.AreEqual(1, work.TrackRoutes.Get().First(tr => tr.ID == 1).ID);
        }

        [TestMethod]
        public void TrackRouteAdd()
        {
            work.Tracks.Add(new Track(60));
            Assert.AreEqual(60, work.Tracks.Get().First(track => track.ID == 60).ID);
        }

        [TestMethod]
        public void TrackRouteUpdate()
        {
            Track track = work.Tracks.Get().First();

            track.ID = 999;

            work.Tracks.Update(track);

            Assert.AreEqual(999, work.Tracks.Get().First().ID);
        }
    }
}

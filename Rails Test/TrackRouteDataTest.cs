using System;
using System.Linq;
using CTRails.DAL;
using CTRails.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rails_Test
{
    [TestClass]
    public class TrackDataTest
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
        public void TrackRetrieve()
        {
            Assert.AreEqual(1, work.Tracks.Get().First(track => track.ID == 1).ID);
        }

        [TestMethod]
        public void TrackAdd()
        {
            work.Tracks.Add(new Track(60));
            Assert.AreEqual(60, work.Tracks.Get().First(track => track.ID == 60).ID);
        }

        [TestMethod]
        public void TrackUpdate()
        {
            Track track = work.Tracks.Get().First();

            track.ID = 999;

            work.Tracks.Update(track);

            Assert.AreEqual(999, work.Tracks.Get().First().ID);
        }
    }
}

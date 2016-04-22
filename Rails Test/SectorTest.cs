using System;
using System.Collections.Generic;
using System.Linq;
using CTRails.DAL;
using CTRails.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rails_Test
{
    [TestClass]
    public class SectorTest
    {

        private UnitOfWork work;

        [TestInitialize]
        public void Initialize()
        {
            work = new UnitOfWork();
        }


        [TestCleanup]
        public void Clean()
        {
            work = null;
        }

        [TestMethod]
        public void TestRetrieve()
        {
            IEnumerable<Sector> sectors = work.Sectors.Get().Where(x => x.Tram != null);

            Assert.AreNotEqual(0, sectors.Count());
        }

        [TestMethod]
        public void TestAdd()
        {
            work.Sectors.Add(new Sector(15, 5));
            Assert.AreEqual(5, work.Sectors.Where(x => x.Number == 15).First().TrackID);
        }

        [TestMethod]
        public void TestUpdate()
        {
            Sector s = work.Sectors.Get().First();

            s.TrackID = 25;

            work.Sectors.Update(s);

            Assert.AreEqual(25, work.Sectors.Get().First().TrackID);
        }
    }
}

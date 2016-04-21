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
        public void TestRetrieve()
        {
            Assert.AreEqual(1, work.Sectors.Where(x => x.SectionNumber == 1).First().TrackNumber);
        }

        [TestMethod]
        public void TestAdd()
        {
            work.Sectors.Add(new Sector(15, 5));
            Assert.AreEqual(5, work.Sectors.Where(x => x.SectionNumber == 15).First().TrackNumber);
        }

        [TestMethod]
        public void TestUpdate()
        {
            Sector s = work.Sectors.Get().First();

            s.TrackNumber = 25;

            work.Sectors.Update(s);

            Assert.AreEqual(25, work.Sectors.Get().First().TrackNumber);
        }
    }
}

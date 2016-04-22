using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CTRails;
using System.Threading.Tasks;
using CTRails.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rails_Test
{
    [TestClass]
    public class TramTest
    {
        private UnitOfWork work;
        [TestInitialize]
        public void Initialize()
        {
            work = new UnitOfWork(true);
        }

        [TestMethod]
        public void InsertTram()
        {
            Tram tram = new Tram(50, 3345);

            work.Trams.Add(tram);

            //Assert.AreEqual(tram.Code, work.Trams.Get().);
        }

        [TestCleanup]
        public void CleanUp()
        {
            work = null;
        }
    }
}

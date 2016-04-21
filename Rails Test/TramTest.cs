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
        private UnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            unitOfWork = new UnitOfWork();
        }

        [TestMethod]
        public void InsertTram()
        {
            
            Tram tram = new Tram(1,
                                 unitOfWork.Statuses.Where(status => status.Name()));
            // Tram moet meerdere statussen kunnen bevatten.
        }

        [TestCleanup]
        public void CleanUp()
        {
            unitOfWork = null;
        }
    }
}

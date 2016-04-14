using System;
using CTRails;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTRails.DAL;

namespace Rails_Test
{
    [TestClass]
    public class UnitTest1
    {
        private CTRails.Entities.Employees.Employee werknemer;
        private UnitOfWork unitOfWork;
        private Tram tram;

        [TestMethod]
        public void Insert()
        {
            //test fields
            int id = 1;
            
            unitOfWork.
            unitOfWork = new UnitOfWork();
            unitOfWork.Employees.Add(werknemer = new CTRails.Entities.Employees.Employee());
        }

        [TestMethod]
        public int GetInt()
        {

            if (tram.ID != this.tram.ID)
                return tram.ID;

            else return 0;
        }
    }
}

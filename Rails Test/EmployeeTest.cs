using System;
using CTRails;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTRails.DAL;
using CTRails.DAL.Contexts;

namespace Rails_Test
{
    [TestClass]
    public class EmployeeTest
    {
        private UnitOfWork unitOfWork;
        private Tram tram;
        private IDataContext<Tram> context;

        [TestMethod]
        public void Insert()
        {
            //test fields
            int code = 1;

            unitOfWork = new UnitOfWork();
            unitOfWork.Trams.Add(new Tram(code));
            unitOfWork.Employees.Add(new CTRails.Entities.Employees.Employee());
        }

        //[TestMethod]
        //public void tramrepository(IDataContext<Tram> context)
        //{
        //    context = this.context;
        //}

        //[TestMethod]
        //public int GetInt()
        //{
            
        //    if (tram.ID != this.tram.ID)
        //        return tram.ID;

        //    else return 0;
        //}
    }
}

using System;
using System.Linq;
using CTRails;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTRails.DAL;
using CTRails.DAL.Contexts;
using CTRails.Entities;


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

            unitOfWork.Employees.Add(new CTRails.Entities.Employees.Employee(
                unitOfWork.AccountTypes.Where(accountType => accountType.Name == "FleetAdministrator").First(), 
                "willem", 
                "willem", 
                "willem", 
                "willem", 
                string.Empty, 
                "willem@willem.willem", 
                DateTime.Now, 
                "NL", 
                new Address("Willemstraat", 1, "Willemsinky", "Willem", "1234WI", "W"),
                Gender.M 
                ));
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

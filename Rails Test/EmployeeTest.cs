using System;
using System.Linq;
using CTRails;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTRails.DAL;
using CTRails.DAL.Contexts;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace Rails_Test
{
    [TestClass]
    public class EmployeeTest
    {
        private UnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            unitOfWork = new UnitOfWork(true);
        }

        [TestCleanup]
        public void CleanUp()
        {
            unitOfWork = null;
        }


        [TestMethod]
        public void InsertEmployee()
        {
            //test fields
            unitOfWork.Employees.Add(new Employee(
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

            Assert.AreEqual("willem@willem.willem", unitOfWork.Employees.Get().First(x => x.Email == "willem@willem.willem").Email);
        }
    }
}

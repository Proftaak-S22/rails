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
            unitOfWork = new UnitOfWork();
        }


        [TestMethod]
        public void InsertEmployee()
        {

            Employee employee = new Employee(
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
                );

            //test fields
            unitOfWork.Employees.Add(employee);

            Assert.AreEqual(employee, unitOfWork.Employees.Where(x => x.Email == "willem@willem.willem").First());
        }

        [TestCleanup]
        public void CleanUp()
        {
            unitOfWork = null;
        }
    }
}

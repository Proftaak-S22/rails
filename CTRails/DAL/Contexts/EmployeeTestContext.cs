using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using CTRails.Entities;
using CTRails.Entities.Employees;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class EmployeeTestContext : TestDatabaseContext<Employee>, IDataContext<Employee>
    {

        private int ID => id++;
        private int id = 0;

        public EmployeeTestContext()
            : base()
        {
            Entities.Add(new Employee(ID, new AccountType(0, "Janitor"),
                "janitor",
                "janitor",
                "Harrie",
                "De Pariie",
                "Van",
                "harrie@m.i",
                DateTime.MaxValue, 
                "BE",
                new Address("harriestraat", 22, "Son en Harrie", "Haat", "1337HA", "B"),
                Gender.M));

            Entities.Add(new Employee(ID, new AccountType(0, "FleetAdministrator"),
                "fleet",
                "fleet",
                "Willem",
                "Keeris",
                string.Empty,
                "xXevil_devil_manXx@666.dark",
                DateTime.MinValue,
                "NL",
                new Address("Satanlaan", 666, "Lucifer", "Hell", "0666XX", "B"),
                Gender.M));
        }

        public void Add(Employee entity)
        {
            Entities.Add(entity);
        }



        public void Delete(Employee entity)
        {
            Entities.Remove(entity);
        }



        public void Update(Employee entity)
        {
            Employee updated = Entities.First(x => x.ID == entity.ID);
            if (updated != null)
                updated = entity;
        }



        public IEnumerable<Employee> Get()
        {
            return Entities;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using CTRails.Entities;
using CTRails.Entities.Employees;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class EmployeeTestContext : TestDatabaseContext<Employee>, IDataContext<Employee>
    {

        private int id = 0;
        private int NextID => id++;
        public EmployeeTestContext()
            : base()
        {
            Entities.Add(new Employee(NextID, 4,
                "janitor",
                "janitor",
                "Harrie",
                "De Pariie",
                "Van",
                "harrie@m.i",
                new DateTime(1992, 1, 12), 
                "BE",
                new Address("harriestraat", 22, "Son en Harrie", "Haat", "1337HA", "B"),
                Gender.M));

            Entities.Add(new Employee(NextID, 3,
                "fleet",
                "fleet",
                "Willem",
                "Keeris",
                string.Empty,
                "xXevil_devil_manXx@666.dark",
                new DateTime(1990, 5, 9),
                "NL",
                new Address("Satanlaan", 666, "Lucifer", "Hell", "0666XX", "B"),
                Gender.M));

            Entities.Add(new Employee(NextID, 21,
                "lj",
                "lj",
                "Kees",
                "van Pees",
                string.Empty,
                "keesvp@pees.kees",
                new DateTime(1992, 9, 15),
                "NL",
                new Address("harriestraat", 24, "Son en Harrie", "Haat", "1337HA", "B"),
                Gender.M));

            Entities.Add(new Employee(NextID, 1,
                "admin",
                "admin",
                "Jaap",
                "Gaap",
                string.Empty,
                "hoihoi@hoi.hoi",
                new DateTime(1960, 4, 2),
                "NL",
                new Address("harriestraat", 24, "Son en Harrie", "Haat", "1337HA", "B"),
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

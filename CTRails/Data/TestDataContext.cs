using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTRails.Interfaces;
using CTRails.Users;


namespace CTRails.DataContexts
{
    public class TestDataContext : IRailsDataContext
    {

        public IEnumerable<Employee> Employees
        {
            get
            {
                Employee e = new Schoonmaker("harrie", Geslacht.M, DateTime.MaxValue, "ssdf", "a", string.Empty, string.Empty);
                List<Employee> l = new List<Employee>();
                l.Add(e);
                return l;
            }
        }


        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

    }
}

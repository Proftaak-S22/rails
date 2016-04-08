using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CTRails.Interfaces;
using CTRails.Users;


namespace CTRails.DataContexts
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {

        public EmployeeRepository(IRailsDataContext context)
            : base(context)
        {
            
        }



        public override Employee Get(int id)
        {
            List<Employee> employees = context.Employees.ToList();
            return employees.First(x => x.ID == id);
        }

    }
}

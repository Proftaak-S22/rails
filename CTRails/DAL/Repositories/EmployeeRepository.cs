using System;
using System.Collections.Generic;
using CTRails.DAL.Contexts;
using CTRails.Entities.Employees;


namespace CTRails.DAL.Repositories
{
    public class EmployeeRepository : Repository<Employee>
    {
        public EmployeeRepository(IDataContext<Employee> context)
            : base(context)
        {
            
        }

    }
}

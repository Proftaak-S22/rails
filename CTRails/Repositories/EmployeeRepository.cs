﻿using System.Collections.Generic;
using System.Linq;
using CTRails.Data;
using CTRails.Entities.Employees;


namespace CTRails.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {

        public EmployeeRepository(IRailsDataContext context)
            : base(context)
        {
            
        }

    }
}

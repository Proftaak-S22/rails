﻿using System.Collections.Generic;
using System.Linq;
using CTRails.Data;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails.Repositories
{
    public class StatusRepository : Repository<Status>, IStatusRepository
    {

        public IRailsDataContext Context { get; set; }



        public StatusRepository(IRailsDataContext context)
            : base(context)
        {
            Context = context;
        }

    }
}

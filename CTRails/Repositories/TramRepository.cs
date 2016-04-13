﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Repositories
{
    class TramRepository : Repository<Tram>, ITramRepository
    {

        public TramRepository(IRailsDataContext context)
            : base(context)
        {

        }

    }
}

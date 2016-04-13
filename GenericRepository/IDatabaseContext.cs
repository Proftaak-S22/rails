﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
    public interface IDatabaseContext<T>
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        IEnumerable<T> Get();

    }
}

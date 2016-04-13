using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using CTRails.Data;


namespace CTRails.Repositories
{
    public interface IRailsRepository<T> : IRepository<T> where T : class
    {
        IRailsDataContext Context { get; }
    }
}

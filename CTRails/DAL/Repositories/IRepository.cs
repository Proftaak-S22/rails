using System;
using System.Collections.Generic;


namespace CTRails.DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

        IEnumerable<T> Get();
        IEnumerable<T> Where(Func<T, bool> predicate);
    }
}

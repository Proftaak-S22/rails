using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace GenericRepository
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

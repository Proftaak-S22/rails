using System;
using System.Collections.Generic;


namespace CTRails.DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> predicate);

        // This method was not in the videos, but I thought it would be useful to add.
        T SingleOrDefault(Func<T, bool> predicate);

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;


namespace CTRails.DAL.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {

        protected IDataContext context;

        public Repository(IDataContext context)
        {
            this.context = context;
        } 

        public virtual T Get(int id)
        {
            return context.Set<T>().First(x => 
            x.GetType().GetProperty("ID", typeof(int)) != null && 
            (int) x.GetType().GetProperty("ID", typeof(int)).GetValue(x) == id);
        }



        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }



        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return context.Set<T>().Where(predicate);
        }



        public T SingleOrDefault(Func<T, bool> predicate)
        {
            return context.Set<T>().SingleOrDefault(predicate);
        }



        public virtual void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }



        public virtual void AddRange(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
                context.Set<T>().Add(entity);
        }



        public virtual void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }



        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
                context.Set<T>().Remove(entity);
        }

    }
}

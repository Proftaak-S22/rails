using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace GenericRepository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {

        public IDatabaseContext<T> Context { get; protected set; }


        public Repository(IDatabaseContext<T> context)
        {
            Context = context;
        }


        public void Add(T entity)
        {
            Context.Add(entity);
        }



        public void Delete(T entity)
        {
            Context.Delete(entity);
        }



        public void Update(T entity)
        {
            Context.Update(entity);
        }



        public IEnumerable<T> Get()
        {
            return Context.Get();
        }



        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
            return Context.Get().Where(predicate);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using CTRails.DAL.Contexts;


namespace CTRails.DAL.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {

        protected IDataContext<T> context;

        public Repository(IDataContext<T> context)
        {
            this.context = context;
        }

        public virtual void Add(T entity)
        {
            context.Add(entity);
        }



        public virtual void Delete(T entity)
        {
            context.Add(entity);
        }



        public virtual void Update(T entity)
        {
            context.Add(entity);
        }


        public IEnumerable<T> Get()
        {
            return context.Get();
        }

        public virtual IEnumerable<T> Where(Func<T, bool> predicate)
        {
            return context.Get().Where(predicate);
        }

    }
}

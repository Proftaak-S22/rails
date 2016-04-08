using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CTRails.Interfaces;


namespace CTRails.DataContexts
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {

        protected IRailsDataContext context;



        public Repository(IRailsDataContext context)
        {
            this.context = context;
        } 

        public virtual T Get(int id)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }



        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }



        public virtual T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }



        public virtual void Add(T entity)
        {
            throw new NotImplementedException();
        }



        public virtual void AddRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }



        public virtual void Remove(T entity)
        {
            throw new NotImplementedException();
        }



        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

    }
}

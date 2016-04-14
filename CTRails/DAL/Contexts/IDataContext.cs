using System.Collections.Generic;


namespace CTRails.DAL.Contexts
{

    public interface IDataContext<T>
    {
        void Add (T entity);
        void Delete (T entity);
        void Update (T entity);
        IEnumerable<T> Get(); 
    }
}

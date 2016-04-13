using System.Collections.Generic;


namespace CTRails.DAL
{

    public interface IDataContext
    {
        ICollection<T> Set <T>();
        void SaveChanges();
    }
}

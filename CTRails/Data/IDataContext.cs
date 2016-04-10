using System.Collections.Generic;


namespace CTRails.Data
{

    public interface IDataContext
    {

        ICollection<T> Set <T>();
        void SaveChanges();


    }
}

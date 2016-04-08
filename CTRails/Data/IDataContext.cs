using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CTRails.Users;


namespace CTRails.Interfaces
{

    public interface IDataContext
    {


        void SaveChanges();


    }
    public interface IDataContext<T> where T : class
    {


        T Find(int id);

    }
}

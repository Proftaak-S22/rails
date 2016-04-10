using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Data
{

    public abstract class DataContext : IDataContext
    {

        public virtual ICollection<T> Set<T>()
        {
            PropertyInfo p = GetType().GetProperties().First(x => x.GetMethod.ReturnType == typeof(IEnumerable<T>));

            return p.GetValue(this, null) as ICollection<T>;
        }



        public virtual void SaveChanges()
        {
            throw new NotImplementedException();
        }

    }

}

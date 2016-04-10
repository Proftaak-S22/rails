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
            PropertyInfo[] properties = GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.GetMethod.ReturnType == typeof(IEnumerable<T>))
                    return property.GetValue(this, null) as ICollection<T>;
            }

            return null;
        }



        public virtual void SaveChanges()
        {
            throw new NotImplementedException();
        }

    }

}

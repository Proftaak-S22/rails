using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CTRails.Entities.Employees;
using CTRails.Exceptions;


namespace CTRails.Data
{

    public abstract class DataContext : IDataContext
    {

        /// <summary>
        /// Returns a collection of entities that match the specified type.
        /// </summary>
        /// <typeparam name="T"> Specifies the type to grab from the dataset. </typeparam>
        /// <exception cref="CTRails.Exceptions.EntityNotPresentException"> Thrown when the requested entity of type T is not present in the data context. </exception>
        public virtual ICollection<T> Set<T>()
        {
            // We want to find the property that returns a collection of the same type as T.
            // The IEnumerable interface stands highest in the collection interfaces hierarchy so thats what we need to be searching for
            // for the best results. 
            PropertyInfo p = GetType().GetProperties().First(x => x.GetMethod.ReturnType == typeof(IEnumerable<T>));

            // If none, error.
            if (p == null)
                throw new EntityNotPresentException("The requested type " + typeof(T) + " is not present in this data context.");

            // Get the actual collection and return it.
            return p.GetValue(this, null) as ICollection<T>;
        }



        public virtual void SaveChanges()
        {
            throw new NotImplementedException();
        }

    }

}

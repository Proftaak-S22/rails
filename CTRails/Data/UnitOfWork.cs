using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTRails.Interfaces;


namespace CTRails.DataContexts
{
    public class UnitOfWork : IUnitOfWork
    {

        private IRailsDataContext context;



        public UnitOfWork(IRailsDataContext context)
        {
            this.context = context;

            Employees = new EmployeeRepository(context);

            
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }



        public IEmployeeRepository Employees { get; private set; }



        public int Complete()
        {
            context.SaveChanges();
            return 1;
        }

    }
}

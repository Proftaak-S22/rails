using System;
using CTRails.Entities.Employees;
using CTRails.Repositories;


namespace CTRails.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        private IRailsDataContext context;



        public UnitOfWork(IRailsDataContext context)
        {
            this.context = context;

            Employees = new EmployeeRepository(context);
            Statuses = new StatusRepository(context);
            AccountTypes = new AccountTypeRepository(context);
            
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Employees = null;
            Statuses = null;
            AccountTypes = null;
            context = null;
        }



        public Repository<Employee> Employees { get; private set; }


        public IStatusRepository Statuses { get; private set; }


        public IAccountTypeRepository AccountTypes { get; private set; }



        public int Complete()
        {
            context.SaveChanges();
            return 1;
        }

    }
}

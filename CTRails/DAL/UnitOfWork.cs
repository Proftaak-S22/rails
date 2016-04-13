using CTRails.DAL.Repositories;


namespace CTRails.DAL
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
            Tracks = new TrackRepository(context);
            
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



        public IEmployeeRepository Employees { get; private set; }


        public IStatusRepository Statuses { get; private set; }


        public IAccountTypeRepository AccountTypes { get; private set; }

        public ITrackRepository Tracks { get; private set; }



        public int Complete()
        {
            context.SaveChanges();
            return 1;
        }

    }
}

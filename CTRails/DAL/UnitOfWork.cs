using CTRails.DAL.Contexts;
using CTRails.DAL.Repositories;


namespace CTRails.DAL
{
    public class UnitOfWork
    {
        
        public UnitOfWork()
        {

            Employees = new EmployeeRepository(new EmployeeOracleContext());
            Statuses = new StatusRepository(new StatusOracleContext());
            AccountTypes = new AccountTypeRepository(new AccountTypeOracleContext());
            Tracks = new TrackRepository(new TrackOracleContext());
            Routes = new RouteRepository(new RouteOracleContext());
        }



        



        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Employees = null;
            Statuses = null;
            AccountTypes = null;
        }



        public EmployeeRepository Employees { get; private set; }


        public StatusRepository Statuses { get; private set; }


        public AccountTypeRepository AccountTypes { get; private set; }

        public TrackRepository Tracks { get; private set; }

        public TrackRouteRepository TrackRoutes { get; private set; }

        public TramRouteRepository TramRoutes { get; private set; }

        public SectorRepository Sectors { get; private set; }

        public AttachedTrackRepository AttachedTracks { get; private set; }

        public RouteRepository Routes { get; private set; }

        public TramRepository Trams { get; private set; }




        public int Complete()
        {
            
            return 1;
        }

    }
}

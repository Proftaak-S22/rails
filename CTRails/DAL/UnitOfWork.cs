using CTRails.DAL.Contexts;
using CTRails.DAL.Repositories;


namespace CTRails.DAL
{
    public class UnitOfWork
    {
        
        public UnitOfWork(bool test = false)
        {
            if (!test)
            {
                AccountTypes = new AccountTypeRepository(new AccountTypeOracleContext());
                AttachedTracks = new AttachedTrackRepository(new AttachedTrackOracleContext());
                Employees = new EmployeeRepository(new EmployeeOracleContext());
                Routes = new RouteRepository(new RouteOracleContext());
                Sectors = new SectorRepository(new SectorOracleContext());
                Statuses = new StatusRepository(new StatusOracleContext());
                Tracks = new TrackRepository(new TrackOracleContext());

                //TrackRoutes = new TrackRouteRepository(new TrackRouteOracleContext());
                Trams = new TramRepository(new TramOracleContext());

                //TramRoutes = new TramRouteRepository(new TramRouteOracleContext());
            }
            {
                Employees = new EmployeeRepository(new EmployeeTestContext());
            }
        }



        



        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Employees = null;
            Statuses = null;
            AccountTypes = null;
            Sectors = null;
        }

        public AccountTypeRepository AccountTypes { get; private set; }
        public AttachedTrackRepository AttachedTracks { get; private set; }
        public EmployeeRepository Employees { get; private set; }
        public RouteRepository Routes { get; private set; }
        public SectorRepository Sectors { get; private set; }
        public StatusRepository Statuses { get; private set; }
        public TrackRepository Tracks { get; private set; }
        public TrackRouteRepository TrackRoutes { get; private set; }
        public TramRepository Trams { get; private set; }
        public TramRouteRepository TramRoutes { get; private set; }










        public int Complete()
        {
            
            return 1;
        }

    }
}

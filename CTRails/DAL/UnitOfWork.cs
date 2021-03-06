﻿using CTRails.DAL.Contexts;
using CTRails.DAL.Repositories;


namespace CTRails.DAL
{
    public class UnitOfWork
    {

        public static bool Test { get; set; } = false;

        public UnitOfWork(bool test = false)
        {
            if (!test && !Test)
            {
                AccountTypes = new AccountTypeRepository(new AccountTypeOracleContext());
                Employees = new EmployeeRepository(new EmployeeOracleContext());
                AttachedTracks = new AttachedTrackRepository(new AttachedTrackOracleContext());
                Routes = new RouteRepository(new RouteOracleContext());
                Sectors = new SectorRepository(new SectorOracleContext());
                Statuses = new StatusRepository(new StatusOracleContext());
                Tracks = new TrackRepository(new TrackOracleContext());
                //TrackRoutes = new TrackRouteRepository(new TrackRouteOracleContext());
                Trams = new TramRepository(new TramOracleContext());
                TramRoutes = new TramRouteRepository(new TramRouteOracleContext());
                Tasks = new TaskRepository(new TaskOracleContext());
            }
            else
            {
                AccountTypes = new AccountTypeRepository(new AccountTypeTestContext());
                Employees = new EmployeeRepository(new EmployeeTestContext());
                Tracks = new TrackRepository(new TrackTestContext());
                Sectors = new SectorRepository(new SectorTestContext());
                Trams = new TramRepository(new TramTestContext());
                Routes = new RouteRepository(new RouteTestContext());
                AttachedTracks = new AttachedTrackRepository(new AttachedTrackTestContext());
                TramRoutes = new TramRouteRepository(new TramRouteTestContext());
                TrackRoutes = new TrackRouteRepository(new TrackRouteTestContext());
                TramStatuses = new TramStatusRepository(new TramStatusTestContext());
                
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

        public TramStatusRepository TramStatuses { get; private set; }

        public TaskRepository Tasks { get; private set; }










        public int Complete()
        {
            
            return 1;
        }

    }
}

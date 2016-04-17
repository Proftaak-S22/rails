using System;
using System.Collections.Generic;
using System.Linq;
using CTRails.Entities;
using CTRails.Entities.Employees;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class TramRouteOracleContext : OracleDatabaseContext, IDataContext<TramRoute>
    {

        public TramRouteOracleContext()
            : base()
        {
            
        }

        public void Add(TramRoute entity)
        {
            throw new NotImplementedException();
        }



        public void Delete(TramRoute entity)
        {
            throw new NotImplementedException();
        }



        public void Update(TramRoute entity)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<TramRoute> Get()
        {
            Connection.Open();

            OracleCommand command = new OracleCommand("SELECT * FROM TRM_TRACK", Connection);

            OracleDataReader reader = command.ExecuteReader();

            List<TramRoute> tramRoutes = new List<TramRoute>();

            UnitOfWork work = new UnitOfWork();

            while (reader.Read())
            {
                int tramId = Convert.ToInt32(reader["TRAM_ID"]);
                int routeId = Convert.ToInt32(reader["ROUTE_ID"]);

                Tram tram = work.Trams.Where(x => x.ID == tramId).First();
                Route route = work.Routes.Where(x => x.ID == routeId).First();

                TramRoute next = new TramRoute(0, tram, route);

                tramRoutes.Add(next);
            }

            return tramRoutes;
        }

    }
}

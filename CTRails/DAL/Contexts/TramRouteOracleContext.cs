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
            OpenConnection();

            string values = "(" + entity.Tram.Code + ", ";
            values += entity.Route.ID + ")";

            OracleCommand cmd = new OracleCommand("INSERT INTO TRM_TRAM_ROUTE (TRAM_ID, ROUTE_ID) VALUES" + values, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }



        public void Delete(TramRoute entity)
        {
            OpenConnection();

            OracleCommand cmd = new OracleCommand("DELETE FROM TRM_TRAM_ROUTE WHERE ID = " + entity.Tram.Code, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }



        public void Update(TramRoute entity)
        {
            OpenConnection();

            string values = "TRAM_ID = " + entity.Tram.Code + ", ";
            values += "ROUTE_ID = " + entity.Route.ID + ")";

            OracleCommand cmd = new OracleCommand("UPDATE TRM_TRAM_ROUTE SET " + values + " WHERE ID = " + entity.ID, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
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

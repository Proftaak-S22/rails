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

            string values = "(" + entity.TramID + ", ";
            values += entity.RouteID + ")";

            OracleCommand cmd = new OracleCommand("INSERT INTO TRM_TRAM_ROUTE (TRAM_ID, ROUTE_ID) VALUES" + values, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }



        public void Delete(TramRoute entity)
        {
            OpenConnection();

            OracleCommand cmd = new OracleCommand("DELETE FROM TRM_TRAM_ROUTE WHERE ID = " + entity.TramID, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }



        public void Update(TramRoute entity)
        {
            OpenConnection();

            string values = "TRAM_ID = " + entity.TramID + ", ";
            values += "ROUTE_ID = " + entity.RouteID + ")";

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

                TramRoute next = new TramRoute(tramId, routeId);

                tramRoutes.Add(next);
            }

            return tramRoutes;
        }

    }
}

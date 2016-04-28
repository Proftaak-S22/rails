using System;
using System.Collections.Generic;
using CTRails.Entities;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class TramOracleContext : OracleDatabaseContext, IDataContext<Tram>
    {

        public TramOracleContext()
            : base()
        {

        }

        public void Add(Tram entity)
        {
            OpenConnection();

            string query = @"INSERT INTO TRM_TRAM (TRAMCODE) VALUES(:tramcode)";

            OracleParameter[] parameters = {
                new OracleParameter(":tramcode", entity.Code)
            };

            ExecuteQuery(query, parameters);

            CloseConnection();
        }



        public void Delete(Tram entity)
        {
            OpenConnection();

            string query = @"DELETE FROM TRM_TRAM WHERE ID = :id";

            OracleParameter[] parameters = {
                new OracleParameter(":id", entity.ID)
            };

            ExecuteQuery(query, parameters);

            CloseConnection();
        }



        public void Update(Tram entity)
        {
            OpenConnection();

            string query = @"UPDATE TRM_TRAM SET TRAMCODE = :tramcode";

            OracleParameter[] parameters = {
                new OracleParameter(":tramcode", entity.Code)
            };

            ExecuteQuery(query, parameters);

            CloseConnection();
        }


        public IEnumerable<Tram> Get()
        {
            OpenConnection();

            string query = @"SELECT ID, TRAMCODE FROM TRM_TRAM";

            OracleDataReader reader = ResultSet(query, null);

            List<Tram> trams = new List<Tram>();

            while (reader.Read())
                trams.Add(new Tram(Convert.ToInt32(reader["ID"]), Convert.ToInt32(reader["TRAMCODE"])));

            // Add routes to trams.
            foreach (Tram t in trams)
            {
                string queryTramRoutes = @"SELECT ID, NAME FROM TRM_ROUTE r INNER JOIN TRM_TRAM_ROUTE tr ON tr.ROUTE_ID = r.ID WHERE tr.TRAM_ID = :tram_id";

                string queryTramStatusses = @"SELECT ID, NAME FROM TRM_STATUS s INNER JOIN TRM_TRAM_STATUS ts ON ts.STATUS_ID = ID WHERE ts.TRAM_ID = :tram_id";
                

                // Retrieve all routes matching this trams ID and include it.
                reader = ResultSet(queryTramRoutes, new[] {
                    new OracleParameter("tram_id", t.ID)
                });
                while (reader.Read())
                    t.Route = new Route(Convert.ToInt32(reader["ID"]), reader["NAME"].ToString());


                // Retrieve all statuses belonging to this trams ID and include them.
                reader = ResultSet(queryTramStatusses, new[] {
                    new OracleParameter("tram_id", t.ID)
                });
                while (reader.Read())
                    t.Statuses.Add(new Status(Convert.ToInt32(reader["ID"]), reader["NAME"].ToString()));

            }

            CloseConnection();

            return trams;
        }

    }
}

using System;
using System.Collections.Generic;
using CTRails.Entities;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class RouteOracleContext : OracleDatabaseContext, IDataContext<Route>
    {

        public TrackOracleContext()
            : base()
        {
            
        }

        public void Add(Route entity)
        {
            throw new NotImplementedException();
        }



        public void Delete(Route entity)
        {
            throw new NotImplementedException();
        }



        public void Update(Route entity)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Route> Get()
        {
            Connection.Open();

            OracleCommand command = new OracleCommand("SELECT * FROM TRM_TRACK", Connection);

            OracleDataReader reader = command.ExecuteReader();

            List<Route> routes = new List<Route>();

            while (reader.Read())
            {
                Route next = new Route(Convert.ToInt32(reader["ID"]),
                    Convert.ToString(reader["NAME"]));

                routes.Add(next);
            }

            return routes;
        }

    }
}

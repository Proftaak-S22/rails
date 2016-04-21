using System;
using System.Collections.Generic;
using CTRails.Entities;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class RouteOracleContext : OracleDatabaseContext, IDataContext<Route>
    {

        public RouteOracleContext()
            : base()
        {
            
        } 

        public void Add(Route entity)
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand("INSERT INTO TRM_ROUTE (NAME) VALUES('" + entity.Name + "')", Connection);
            CloseConnection();
        }



        public void Delete(Route entity)
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand("DELETE FROM TRM_ROUTE WHERE ID =" + entity.ID, Connection);
            CloseConnection();
        }



        public void Update(Route entity)
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand("UPDATE TRM_ROUTE SET NAME = '" + entity.Name + "' WHERE ID = " + entity.ID, Connection);
            CloseConnection();
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

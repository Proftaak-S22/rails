using System;
using System.Collections.Generic;
using CTRails.Entities;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class StatusOracleContext : OracleDatabaseContext, IDataContext<Status>
    {

        public StatusOracleContext()
            : base()
        {
            
        }

        public void Add(Status entity)
        {
            OpenConnection();

            string values = "('" + entity.ID + "', ";
            values += "'" + entity.Name + "')";

            OracleCommand cmd = new OracleCommand("INSERT INTO TRM_STATUS (ID, NAME) VALUES" + values, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }



        public void Delete(Status entity)
        {
            OpenConnection();

            OracleCommand cmd = new OracleCommand("DELETE FROM TRM_STATUS WHERE ID = " + entity.ID, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }



        public void Update(Status entity)
        {
            OpenConnection();

            string values = "ID = '" + entity.ID + "', ";
            values += "NAME = '" + entity.Name + "'";

            OracleCommand cmd = new OracleCommand("UPDATE TRM_STATUS SET " + values + " WHERE ID = " + entity.ID, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }



        public IEnumerable<Status> Get()
        {
            Connection.Open();

            OracleCommand command = new OracleCommand("SELECT * FROM TRM_STATUS", Connection);

            OracleDataReader reader = command.ExecuteReader();

            List<Status> statuses = new List<Status>();

            while (reader.Read())
            {
                Status next = new Status(Convert.ToInt32(reader["ID"]),
                         Convert.ToString(reader["NAME"]));

                statuses.Add(next);
            }

            return statuses;
        }

    }
}

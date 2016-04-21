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

            string values = "('" + entity.ID + "')";

            OracleCommand cmd = new OracleCommand("INSERT INTO TRM_TRAM (ID) VALUES" + values, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }



        public void Delete(Tram entity)
        {
            OpenConnection();

            OracleCommand cmd = new OracleCommand("DELETE FROM TRM_TRAM WHERE ID = " + entity.ID, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }



        public void Update(Tram entity)
        {
            OpenConnection();

            string values = "ID = '" + entity.ID + "'";

            OracleCommand cmd = new OracleCommand("UPDATE TRM_TRAM SET " + values + " WHERE ID = " + entity.ID, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }


        public IEnumerable<Tram> Get()
        {
            OpenConnection();

            OracleCommand command = new OracleCommand("SELECT * FROM TRM_TRACK", Connection);

            OracleDataReader reader = command.ExecuteReader();

            List<Tram> trams = new List<Tram>();

            while (reader.Read())
            {
                Tram next = new Tram(Convert.ToInt32(reader["ID"]), Convert.ToInt32(reader["TRAMCODE"]), null);

                trams.Add(next);
            }

            return trams;
        }

    }
}

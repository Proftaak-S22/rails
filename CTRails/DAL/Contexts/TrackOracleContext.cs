using System;
using System.Collections.Generic;
using System.Linq;
using CTRails.Entities;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class TrackOracleContext : OracleDatabaseContext, IDataContext<Track>
    {

        public TrackOracleContext()
            : base()
        {
            
        }

        public void Add(Track entity)
        {
            OpenConnection();

            string values = "('" + entity.ID + "')";

            OracleCommand cmd = new OracleCommand("INSERT INTO TRM_TRACK(ID) VALUES" + values, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }



        public void Delete(Track entity)
        {
            OpenConnection();

            OracleCommand cmd = new OracleCommand("DELETE FROM TRM_TRACK WHERE ID = " + entity.ID, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }



        public void Update(Track entity)
        {
            OpenConnection();

            string values = "ID= '" + entity.ID + "'";

            OracleCommand cmd = new OracleCommand("UPDATE TRM_EMPLOYEE SET " + values + " WHERE ID = " + entity.ID, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }


        public IEnumerable<Track> Get()
        {
            OpenConnection();

            OracleCommand command = new OracleCommand("SELECT * FROM TRM_TRACK", Connection);

            OracleDataReader reader = command.ExecuteReader();

            List<Track> tracks = new List<Track>();

            UnitOfWork work = new UnitOfWork();

            while (reader.Read())
            {
                Track next = new Track(Convert.ToInt32(reader["ID"]));
                tracks.Add(next);
            }

            CloseConnection();

            return tracks;
        }

    }
}

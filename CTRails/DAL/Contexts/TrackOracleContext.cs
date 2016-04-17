using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }



        public void Delete(Track entity)
        {
            throw new NotImplementedException();
        }



        public void Update(Track entity)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Track> Get()
        {
            OpenConnection();

            OracleCommand command = new OracleCommand("SELECT * FROM TRM_TRACK", Connection);

            OracleDataReader reader = command.ExecuteReader();

            List<Track> tracks = new List<Track>();

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

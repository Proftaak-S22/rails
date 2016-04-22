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
            throw new NotImplementedException();
        }



        public void Delete(Tram entity)
        {
            throw new NotImplementedException();
        }



        public void Update(Tram entity)
        {
            throw new NotImplementedException();
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

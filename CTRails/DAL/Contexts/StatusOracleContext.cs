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
            throw new NotImplementedException();
        }



        public void Delete(Status entity)
        {
            throw new NotImplementedException();
        }



        public void Update(Status entity)
        {
            throw new NotImplementedException();
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

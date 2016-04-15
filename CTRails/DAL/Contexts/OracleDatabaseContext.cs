using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public abstract class OracleDatabaseContext
    {

        public string ConnectionString { get; protected set; } = "User Id=dbi346087;Password=Tram123;DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=fhictora)));";
        public OracleConnection Connection { get; protected set; }


        public OracleDatabaseContext(string connectionString)
        {
            ConnectionString = connectionString;
            Connection = new OracleConnection(connectionString);
        }

        public OracleDatabaseContext()
        {
            Connection = new OracleConnection(ConnectionString);
        }



        protected void OpenConnection()
        {
            try
            {
                if (Connection.State == ConnectionState.Closed)
                    Connection.Open();
            }
            catch (Oracle.ManagedDataAccess.Client.OracleException)
            {
                Console.WriteLine("A connection could not be opened.");
            }
        }



        protected void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
        }

    }
}

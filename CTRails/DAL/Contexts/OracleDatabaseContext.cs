using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle;
using Oracle.ManagedDataAccess;


namespace CTRails.DAL.Contexts
{
    public abstract class OracleDatabaseContext
    {

        /// <summary>
        /// Connection parameters.
        /// </summary>
        public string ConnectionString { get; protected set; } = "User Id=dbi346087;Password=Tram123;DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=fhictora)));";



        /// <summary>
        /// The contexts database connection.
        /// </summary>
        public OracleConnection Connection { get; protected set; }


        /// <summary>
        /// Creates a new oracle db context with the specified connection string.
        /// </summary>
        /// <param name="connectionString"> Specifies the connection string. </param>
        public OracleDatabaseContext(string connectionString)
        {
            ConnectionString = connectionString;
            Connection = new OracleConnection(connectionString);
        }



        /// <summary>
        /// Creates an oracle db context with the default connection string.
        /// </summary>
        public OracleDatabaseContext()
        {
            Connection = new OracleConnection(ConnectionString);
        }



        /// <summary>
        /// Opens a database connection.
        /// </summary>
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


        /// <summary>
        /// Executes the given query with the specified parameters.
        /// </summary>
        /// <param name="query"> Specifies the query to execute. </param>
        /// <param name="parameters"> Specifies the parameters to apply. </param>
        protected void ExecuteQuery(string query, OracleParameter[] parameters)
        {
            OracleCommand command = new OracleCommand(query, Connection);

            if (parameters != null)
                foreach (OracleParameter p in parameters)
                    command.Parameters.Add(p);

            command.ExecuteNonQuery();
        }



        /// <summary>
        /// Returns a set of rows resulting from the exucuted query.
        /// </summary>
        /// <param name="query"> Specifies the query to execute. </param>
        /// <param name="parameters"> Specifies the parameters to apply. </param>
        /// <returns></returns>
        public OracleDataReader ResultSet(string query)
        {
            return ResultSet(query, new OracleParameter[]
            {});
        }



        /// <summary>
        /// Returns a set of rows resulting from the exucuted query.
        /// </summary>
        /// <param name="query"> Specifies the query to execute. </param>
        /// <param name="parameters"> Specifies the parameters to apply. </param>
        /// <returns></returns>
        public OracleDataReader ResultSet(string query, OracleParameter[] parameters)
        {
            OracleCommand command = new OracleCommand(query, Connection);

            if (parameters != null)
                foreach (OracleParameter p in parameters)
                    command.Parameters.Add(p);

            return command.ExecuteReader();
        }



        /// <summary>
        /// Closes the database connection.
        /// </summary>
        protected void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
        }

    }
}

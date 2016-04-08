using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTRails.Interfaces;
using CTRails.Users;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.Data
{
    public class OracleDataContext : IRailsDataContext
    {

        private string connectionString = "User Id=dbi346087;Password=Tram123;DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=fhictora)));";
        private OracleConnection connection;
        private string username;
        private string password;
        private string host;
        private string port;
        private string serviceName;


        public OracleDataContext(string username, string password, string host, string port, string serviceName)
        {
            this.username = username;
            this.password = password;
            this.host = host;
            this.port = port;
            this.serviceName = serviceName;

            connectionString = "User Id=" + username + ";Password=" + password + ";DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=" + host + ")(PORT=" + port + "))(CONNECT_DATA=(SERVICE_NAME=" + serviceName + ")));";
        }

        public OracleDataContext() { }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }



        public IEnumerable<Employee> Employees
        {
            get
            {
                connection = new OracleConnection
                {
                    ConnectionString = connectionString
                };
                connection.Open();
                string query = "SELECT * FROM TRM_EMPLOYEE";
                OracleCommand command = new OracleCommand(query, connection);
                OracleDataReader reader = command.ExecuteReader();
                List<Employee> employees = new List<Employee>();
                while (reader.Read())
                {
                    Employee x = new Schoonmaker(string.Empty, Geslacht.M, DateTime.MaxValue, string.Empty, string.Empty, string.Empty, string.Empty);
                    employees.Add(x);
                }
                connection.Close();
                return employees;
            }
        }

    }
}

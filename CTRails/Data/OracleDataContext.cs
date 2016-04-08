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

        private OracleConnection connection;

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
                    ConnectionString = "User Id=dbi346087;Password=Tram123;DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=fhictora)));"
                };
                string query = "SELECT * FROM TRM_EMPLOYEE";
                OracleCommand command = new OracleCommand(query);
                OracleDataReader reader = command.ExecuteReader();
                List<Employee> employees = new List<Employee>();

                while (reader.Read())
                {
                    Employee x = new Schoonmaker(string.Empty, Geslacht.M, DateTime.MaxValue, string.Empty, string.Empty, string.Empty, string.Empty);
                    employees.Add(x);
                }

                return employees;
            }
        }

    }
}

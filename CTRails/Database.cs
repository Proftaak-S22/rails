using System;
using CTRails.Entities;
using CTRails.Entities.Employees;
using Oracle.ManagedDataAccess.Client;

namespace CTRails
{
    public class Database
    {

        /// <summary>
        /// Database singleton instance.
        /// </summary>
        public static Database Instance
        {
            get
            {
                if (instance == null)
                    instance = new Database();

                return instance;

            }
        }
        private static Database instance;

        
        private OracleConnection connection;

        private Database()
        {
            connection = new OracleConnection
            {
                ConnectionString = "User Id=dbi346087;Password=Tram123;DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=fhictora)));"
            };
        }


        public void GetUser(Employee user)
        {
            //string que
        }



        public void GetUser(int id)
        {
            string query = "SELECT * FROM TRM_EMPLOYEE";
            OracleCommand command = new OracleCommand(query);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine((string)reader[0]);
            }
        }



        public void GetTram(Tram tram)
        {
            
        }



        public void GetTrack(Track track)
        {
            
        }
    }
}

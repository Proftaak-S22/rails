using System;
using System.Collections.Generic;
using CTRails.DAL.Contexts;
using CTRails.Entities;
using CTRails.Entities.Employees;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL
{
    
    public abstract class OracleDataContext<T> : IDataContext<T>
    {

        private string connectionString = "User Id=dbi346087;Password=Tram123;DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=fhictora)));";
        private OracleConnection connection;


        private ICollection<Employee> employees;
        private ICollection<Status> statuses;
        private ICollection<AccountType> accountTypes;
        private ICollection<Sector> sectors;


        public OracleDataContext(string connection)
        {
            this.connection = new OracleConnection(connection);
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> Get()
        {
            throw new NotImplementedException();
        } 



        private OracleDataReader ConnectAndQuery(string query)
        {
            connection = new OracleConnection
            {
                ConnectionString = connectionString
            };

            try
            {
                connection.Open();
            }
            catch (Oracle.ManagedDataAccess.Client.OracleException)
            {
                
            }

            OracleCommand command = new OracleCommand(query, connection);
            return command.ExecuteReader();
        }



        private void Close()
        {
            connection.Close();
        }



        
        public IEnumerable<Employee> Employees
        {
            get
            {
                if (employees != null)
                    return employees;

                OracleDataReader reader = ConnectAndQuery("SELECT * FROM TRM_EMPLOYEE");

                employees = new List<Employee>();

                while (reader.Read())
                {
                    Address address = new Address(
                        string.Empty,
                        Convert.ToInt32(reader["HOUSENUMBER"]),
                        Convert.ToString(reader["CITY"]),
                        string.Empty,
                        Convert.ToString(reader["POSTALCODE"]),
                        Convert.ToString(reader["ADDITION"]));

                    Gender gender = Convert.ToChar(reader["SEX"]) == 'M' ? Gender.M : Gender.F;

                    Employee next = new Janitor(
                        Convert.ToInt32(reader["ID"]),
                        null,
                        reader["USERNAME"].ToString(),
                        reader["PASSWORDHASH"].ToString(),
                        reader["FIRSTNAME"].ToString(),
                        reader["LASTNAME"].ToString(),
                        reader["PREFIX"].ToString(),
                        reader["EMAIL"].ToString(),
                        Convert.ToDateTime(reader["BIRTHDATE"]),
                        reader["NATIONALITY"].ToString(),
                        address,
                        gender);

                    employees.Add(next);
                }
                
                Close();

                return employees;
            }
        }


        
        public IEnumerable<Status> Statuses
        {
            get
            {
                if (statuses != null)
                    return statuses;

                OracleDataReader reader = ConnectAndQuery("SELECT * FROM TRM_STATUS");

                statuses = new List<Status>();

                while (reader.Read())
                {
                    Status status = new Status(Convert.ToInt32(reader["ID"]),
                        Convert.ToString(reader["NAME"]));

                    statuses.Add(status);
                }

                Close();

                return statuses;
            }
        }


        public IEnumerable<AccountType> AccountTypes
        {
            get
            {
                if (accountTypes != null)
                    return accountTypes;

                OracleDataReader reader = ConnectAndQuery("SELECT * FROM TRM_ACCOUNTTYPE");

                accountTypes = new List<AccountType>();

                while (reader.Read())
                {
                    AccountType accountType = new AccountType(
                        Convert.ToInt32(reader["ID"]),
                        Convert.ToString(reader["NAME"]));

                    accountTypes.Add(accountType);
                }

                Close();

                return accountTypes;
            }
        }

        public IEnumerable<Sector> Sectors
        {
            get
            {
                if (sectors != null)
                    return sectors;

                OracleDataReader reader = ConnectAndQuery("SELECT * FROM TRM_SECTION");

                sectors = new List<Sector>();

                while (reader.Read())
                {
                    Sector sector = new Sector(
                        Convert.ToInt32(reader["ID"]),
                        Convert.ToInt32(reader["TRACK_ID"]));

                    sectors.Add(sector);
                }

                Close();

                return sectors;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using CTRails.Entities.Employees;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class EmployeeOracleContext : OracleDatabaseContext, IDataContext<Employee>
    {

        public EmployeeOracleContext()
            : base()
        {
            
        }

        public void Add(Employee entity)
        {
            throw new NotImplementedException();
        }



        public void Delete(Employee entity)
        {
            throw new NotImplementedException();
        }



        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<Employee> Get()
        {
            Connection.Open();

            OracleCommand command = new OracleCommand("SELECT * FROM TRM_EMPLOYEE", Connection);

            OracleDataReader reader = command.ExecuteReader();

            List<Employee> employees = new List<Employee>();

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

            return employees;
        }

    }
}

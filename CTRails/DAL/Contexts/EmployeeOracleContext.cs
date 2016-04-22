using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
            OpenConnection();

            string values = "(1, '" + entity.Username + "', ";
            values += "'" + entity.Gender + "', ";
            values += "'" + entity.Password + "', ";
            values += "'" + entity.FirstName + "', ";
            values += "'" + entity.LastName + "', ";
            values += (entity.Prefix == string.Empty) ? "NULL, " :  "'" + entity.Prefix + "', ";
            values += "'" + entity.Email + "', ";
            values += ToOracleDate(entity.DateOfBirth) + ", ";
            values += "'" + entity.Nationality + "', ";
            values += "'" + entity.Address.Zipcode + "', ";
            values += "'" + entity.Address.City + "', ";
            values += entity.Address.Number + ", ";
            values += "'" + entity.Address.Addition + "')";

            OracleCommand cmd = new OracleCommand("INSERT INTO TRM_EMPLOYEE (ACCOUNTTYPE_ID, USERNAME, SEX, PASSWORDHASH, FIRSTNAME, LASTNAME, PREFIX, EMAIL, BIRTHDATE, NATIONALITY, POSTALCODE, CITY, HOUSENUMBER, ADDITION) VALUES" + values, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }



        public void Delete(Employee entity)
        {
            OpenConnection();

            OracleCommand cmd = new OracleCommand("DELETE FROM TRM_EMPLOYEE WHERE ID = " + entity.ID, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }



        public void Update(Employee entity)
        {
            OpenConnection();

            string values = "USERNAME = '" + entity.Username + "', ";
            values += "SEX = '" + entity.Gender + "', ";
            values += "PASSWORDHASH = '" + entity.Password + "', ";
            values += "FIRSTNAME = '" + entity.FirstName + "', ";
            values += "LASTNAME = '" + entity.LastName + "', ";
            values += "PREFIX = " + ((entity.Prefix == string.Empty) ? "NULL, " : "'" + entity.Prefix + "', ");
            values += "EMAIL = '" + entity.Email + "', ";
            values += "BIRTHDATE = TO_DATE('" + ToOracleDate(entity.DateOfBirth) + "', 'DD-MON-YY'), ";
            values += "NATIONALITY = '" + entity.Nationality + "', ";
            values += "POSTALCODE = '" + entity.Address.Zipcode + "', ";
            values += "CITY = '" + entity.Address.City + "', ";
            values += "HOUSENUMBER = " + entity.Address.Number + ", ";
            values += "ADDITION = '" + entity.Address.Addition + "'";

            OracleCommand cmd = new OracleCommand("UPDATE TRM_EMPLOYEE SET ACCOUNTTYPE_ID = 1, " + values + " WHERE ID = " + entity.ID, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }



        public IEnumerable<Employee> Get()
        {
            OpenConnection();

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
                    Convert.ToInt32(reader["ACCOUNTTYPE_ID"]),
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

            CloseConnection();

            return employees;
        }

        public string ToOracleDate(DateTime date)
        {
            return "TO_DATE('" + string.Format("{0:dd-MMM-yy}", date) + "', 'DD-MON-YY')";
        }

    }
}

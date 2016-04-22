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

            string query = @"UPDATE TRM_EMPLOYEE SET ACCOUNTTYPE_ID = :accounttype_id, USERNAME = :username, SEX = :sex, PASSWORDHASH = :passwordhash, FIRSTNAME = :firstname, LASTNAME = :lastname, PREFIX = :prefix, EMAIL = :email, BIRTHDATE = :birthdate, NATIONALITY = :nationality, POSTALCODE = :zipcode, CITY = :city, HOUSENUMBER = :house_number, ADDITION = :addition WHERE ID = :id";

            ExecuteQuery(query, new [] {
                 new OracleParameter("accounttype_id",entity.AccountTypeID),
                 new OracleParameter("username",entity.Username),
                 new OracleParameter("sex",entity.Gender.ToString()),
                 new OracleParameter("passwordhash",entity.Password),
                 new OracleParameter("firstname",entity.FirstName),
                 new OracleParameter("lastname",entity.LastName),
                 new OracleParameter("prefix",entity.Prefix),
                 new OracleParameter("email",entity.Email),
                 new OracleParameter("birthdate",ToOracleDate(entity.DateOfBirth)),
                 new OracleParameter("nationality",entity.Nationality),
                 new OracleParameter("zipcode",entity.Address.Zipcode),
                 new OracleParameter("city",entity.Address.City),
                 new OracleParameter("house_number",entity.Address.Number),
                 new OracleParameter("addition",entity.Address.Addition),
                 new OracleParameter("id",entity.ID)
            });

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

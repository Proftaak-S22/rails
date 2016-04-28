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
            Employee row = Get(entity.ID);

            OpenConnection();

            string query = @"UPDATE TRM_EMPLOYEE SET ";
            string begin = @"UPDATE TRM_EMPLOYEE SET ";
            string end = @" WHERE ID = :id";

            if (row.AccountTypeID != entity.AccountTypeID)
            {
                query = begin + @"ACCOUNTTYPE_ID = :accounttype_id" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("accounttype_id", entity.AccountTypeID),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.Username != entity.Username)
            {
                query = begin + @"USERNAME = :username" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("username", entity.Username),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.Gender.ToString() != entity.Gender.ToString())
            {
                query = begin + @"SEX = :sex" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("sex", entity.Gender.ToString()),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.Password != entity.Password)
            {
                query = begin + @"PASSWORDHASH = :password" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("password", entity.Password),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.FirstName != entity.FirstName)
            {
                query = begin + @"FIRSTNAME = :firstname" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("firstname", entity.FirstName),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.LastName != entity.LastName)
            {
                query = begin + @"LASTNAME = :lastname" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("lastname", entity.LastName),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.Prefix != entity.Prefix)
            {
                query = begin + @"PREFIX = :prefix" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("prefix", entity.Prefix),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.Email != entity.Email)
            {
                query = begin + @"EMAIL = :email" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("email", entity.Email),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.DateOfBirth != entity.DateOfBirth)
            {
                query = begin + @"BIRTHDATE = :birthdate" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("birthdate", ToOracleDate(entity.DateOfBirth)),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.Nationality != entity.Nationality)
            {
                query = begin + @"NATIONALITY = :nationality" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("nationality", entity.Nationality),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.Address.Zipcode != entity.Address.Zipcode)
            {
                query = begin + @"POSTALCODE = :zipcode" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("zipcode", entity.Address.Zipcode),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.Address.City != entity.Address.City)
            {
                query = begin + @"CITY = :city" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("city", entity.Address.City),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.Address.Number != entity.Address.Number)
            {
                query = begin + @"HOUSENUMBER = :number" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("number", entity.Address.Number),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.Address.Addition != entity.Address.Addition)
            {
                query = begin + @"ADDITION = :addition" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("addition", entity.Address.Addition),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }

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



        public Employee Get(int id)
        {
            OpenConnection();

            string query = @"SELECT * FROM TRM_EMPLOYEE WHERE ID = :id";

            OracleDataReader reader = ResultSet(query, new [] {
                new OracleParameter("id", id) 
            });

            Employee result = null;

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

                result = new Janitor(
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
            }

            CloseConnection();

            return result;
        }

        

    }
}

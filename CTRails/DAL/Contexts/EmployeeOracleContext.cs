using System;
using System.Collections.Generic;
using System.Data;
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
            Connection.Open();

            /*string sqlUpdate = "update TRM_EMPLOYEE ";
            sqlUpdate += "set EMAIL = :u_email ";
            sqlUpdate += "WHERE ID = :u_id";

            OracleCommand cmdUpdate = new OracleCommand();
            cmdUpdate.CommandText = sqlUpdate;
            cmdUpdate.Connection = Connection;

            OracleParameter uEmail = new OracleParameter();
            uEmail.Value = entity.Email;
            uEmail.ParameterName = "u_email";

            OracleParameter uID = new OracleParameter();
            uID.DbType = DbType.Int32;
            uID.Value = entity.Id;
            uID.ParameterName = "u_id";

            cmdUpdate.Parameters.Add(uID);
            cmdUpdate.Parameters.Add(uEmail);*/

            if (Connection.State == ConnectionState.Closed)
                Connection.Open();

            OracleCommand cmd = new OracleCommand("UPDATE TRM_EMPLOYEE SET EMAIL = " + " '" + entity.Email + "' " + " WHERE ID = " + entity.ID, Connection);
            cmd.ExecuteNonQuery();

            //string values = string.Format("({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})", entity.Username, entity.Gender, entity.Password, entity.FirstName, entity.LastName, (entity.Prefix == string.Empty) ? "NULL" : entity.Prefix, entity.Email, entity.DateOfBirth, entity.Nationality, entity.Address.Zipcode, entity.Address.City, entity.Address.Number, (entity.Address.Addition == string.Empty) ? "NULL" : entity.Address.Addition);

            //OracleCommand command = new OracleCommand("UPDATE TRM_EMPLOYEE SET (ACCOUNTTYPE_ID, USERNAME, SEX, PASSWORDHASH, FIRSTNAME, LASTNAME, PREFIX, EMAIL, BIRTHDATE, NATIONALITY, POSTALCODE, CITY, HOUSENUMBER, ADDITION) = " + values, Connection);

            //command.ExecuteNonQuery();

            //    + "({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})",entity.Id.to, entity.), Connection);
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

            Connection.Close();

            return employees;
        }

    }
}

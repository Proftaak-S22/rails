using System;
using System.Collections.Generic;
using CTRails.Entities;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class AccountTypeOracleContext : OracleDatabaseContext, IDataContext<AccountType>
    {

        public AccountTypeOracleContext()
            : base()
        {
            
        }

        public void Add(AccountType entity)
        {
            OpenConnection();
            string values = "('" + entity.Name + "')";
            OracleCommand cmd = new OracleCommand("INSERT INTO TRM_ACCOUNTTYPE (NAME) VALUES" + values, Connection);
            CloseConnection();
        }



        public void Delete(AccountType entity)
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand("DELETE FROM TRM_ACCOUNTTYPE WHERE ID = " + entity.ID, Connection);
            CloseConnection();
        }



        public void Update(AccountType entity)
        {
            OpenConnection();
            string values = "('" + entity.Name + "')";
            OracleCommand cmd = new OracleCommand("UPDATE TRM_ACCOUNTTYPE SET NAME = '" + entity.Name + "' WHERE ID = " + entity.ID, Connection);
            CloseConnection();
        }



        public IEnumerable<AccountType> Get()
        {
            OpenConnection();

            OracleCommand command = new OracleCommand("SELECT * FROM TRM_ACCOUNTTYPE", Connection);

            OracleDataReader reader = command.ExecuteReader();

            List<AccountType> accountTypes = new List<AccountType>();

            while (reader.Read())
            {
                AccountType accountType = new AccountType(
                        Convert.ToInt32(reader["ID"]),
                        Convert.ToString(reader["NAME"]));

                accountTypes.Add(accountType);
            }

            return accountTypes;

            CloseConnection();
        }

    }
}

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
            throw new NotImplementedException();
        }



        public void Delete(AccountType entity)
        {
            throw new NotImplementedException();
        }



        public void Update(AccountType entity)
        {
            throw new NotImplementedException();
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

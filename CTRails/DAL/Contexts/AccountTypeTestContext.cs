using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using CTRails.Entities;
using CTRails.Entities.Employees;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class AccountTypeTestContext : TestDatabaseContext<AccountType>, IDataContext<AccountType>
    {

        private int ID => id++;
        private int id = 0;

        public AccountTypeTestContext()
            : base()
        {
            Entities.Add(new AccountType(1, "FleetAdministrator"));
            Entities.Add(new AccountType(2, "Administrator"));
            Entities.Add(new AccountType(3, "Janitor"));
            Entities.Add(new AccountType(4, "LeadJanitor"));
            Entities.Add(new AccountType(5, "Technician"));
            Entities.Add(new AccountType(6, "LeadTechnician"));
            Entities.Add(new AccountType(7, "Driver"));
        }

        public void Add(AccountType entity)
        {
            Entities.Add(entity);
        }



        public void Delete(AccountType entity)
        {
            Entities.Remove(entity);
        }



        public void Update(AccountType entity)
        {
            AccountType updated = Entities.First(x => x.ID == entity.ID);
            if (updated != null)
                updated = entity;
        }



        public IEnumerable<AccountType> Get()
        {
            return Entities;
        }

    }
}

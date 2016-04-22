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

        private int id = 0;
        private int NextID => id++;

        public AccountTypeTestContext()
            : base()
        {
            Entities.Add(new AccountType(NextID, "FleetAdministrator"));
            Entities.Add(new AccountType(NextID, "Administrator"));
            Entities.Add(new AccountType(NextID, "Janitor"));
            Entities.Add(new AccountType(NextID, "LeadJanitor"));
            Entities.Add(new AccountType(NextID, "Technician"));
            Entities.Add(new AccountType(NextID, "LeadTechnician"));
            Entities.Add(new AccountType(NextID, "Driver"));
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

using System;
using System.Collections.Generic;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails.DAL
{
    public class TestDataContext : IRailsDataContext
    {

        public IEnumerable<Employee> Employees
        {
            get { throw new NotImplementedException(); }
        }


        public IEnumerable<Status> Statuses
        {
            get { throw new NotImplementedException(); }
        }


        public IEnumerable<AccountType> AccountTypes
        {
            get { throw new NotImplementedException(); }
        }


        public IEnumerable<T> Set <T>()
        {
            throw new NotImplementedException();
        }



        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}

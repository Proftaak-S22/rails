using System;
using CTRails.DAL;


namespace CTRails.Entities.Employees
{
    public class Administrator : Employee
    {
        //Fields
        private UnitOfWork unit;

        //Constructor
        public Administrator(
            int id,
            int accountTypeID,
            string username,
            string password,
            string firstName,
            string lastName,
            string prefix,
            string email,
            DateTime dateOfBirth,
            string nationality,
            Address address,
            Gender gender
            ) 
            : base(id, accountTypeID, username, password, firstName, lastName, prefix, email, dateOfBirth, nationality, address, gender)
        {
            
        }
    }
}

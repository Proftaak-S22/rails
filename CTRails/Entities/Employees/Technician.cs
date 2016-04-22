using System;


namespace CTRails.Entities.Employees
{
    public class Technician : Employee
    {
        //Fields

        //Constructor
        public Technician(
            int id,
            int AccountTypeID,
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
            : base(id, AccountTypeID, username, password, firstName, lastName, prefix, email, dateOfBirth, nationality, address, gender)
        {
            
        }

    }
}

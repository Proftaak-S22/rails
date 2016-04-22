using System;


namespace CTRails.Entities.Employees
{
    public class FleetAdministrator : Employee
    {
        //Fields

        //Constructor
        public FleetAdministrator(
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

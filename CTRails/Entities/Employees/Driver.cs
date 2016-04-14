using System;


namespace CTRails.Entities.Employees
{
    public class Driver : Employee
    {
        //Fields

        //Constructor
        public Driver(
            int id,
            AccountType accountType,
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
            : base(id, accountType, username, password, firstName, lastName, prefix, email, dateOfBirth, nationality, address, gender)
        {
            throw new NotImplementedException();
        }

        //Methods
        public void EditTramNumber(Tram tram)
        {
            
        }
    }
}

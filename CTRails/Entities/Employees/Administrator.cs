using System;


namespace CTRails.Entities.Employees
{
    public class Administrator : Employee
    {
        //Fields

        //Constructor
        public Administrator(int id,
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
        public void DeleteTram(Tram tram)
        {
            
        }

        public void AddTram(int tramNumber, Status status)
        {
            
        }

        public void AddAccount(string name, Gender gender, DateTime birthDate, Address address, string email,
            string nationality, string userName, string password)
        {
            
        }

        public void VerwijderAccount(Employee user)
        {
            
        }
    }
}

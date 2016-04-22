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
            
        }



        // TODO Redundant method.
        //Methods
        public void DeleteTram(Tram tram)
        {
            unit = new UnitOfWork();
            //unit.Trams.Delete(tram);
        }

        // TODO Redundant method.
        public void AddTram(int tramNumber, Status status)
        {
            unit = new UnitOfWork();
            //unit.Trams.Add(tramNumber, status);
        }

        // TODO Redundant method.
        public void AddAccount(int id,AccountType accountType, string username, string password, string firstName, 
            string lastName, string prefix, string email, DateTime dateOfBirth, string nationality, Address address, Gender gender)
        {
            unit = new UnitOfWork();
            unit.Employees.Add(new Employee(id, accountType, username, password, firstName, lastName, prefix, email, dateOfBirth, nationality, address, gender));
        }

        // TODO Redundant method.
        public void DeleteAccount(Employee user)
        {
            unit = new UnitOfWork();
            unit.Employees.Delete(user);
        }
    }
}

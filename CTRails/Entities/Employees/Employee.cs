using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTRails.Entities;


namespace CTRails.Entities.Employees
{
    public class Employee : Entity
    {
        public AccountType AccountType { get; protected set; }


        public string Username { get; protected set; }
        public string Password { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Prefix { get; protected set; }
        public string Email { get; protected set; }
        public DateTime DateOfBirth { get; protected set; }
        public string Nationality { get; protected set; }
        public Address Address { get; protected set; }
        public Gender Gender { get; protected set; }


        public Employee(int id, 
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
            : base(id)
        {
            AccountType = accountType;
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Prefix = prefix;
            Email = email;
            DateOfBirth = dateOfBirth;
            Nationality = nationality;
            Address = address;
            Gender = gender;
        }

    }
}



public enum Gender
{

    M = 0,
    F

}
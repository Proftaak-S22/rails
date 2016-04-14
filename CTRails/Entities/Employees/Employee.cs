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
        public AccountType AccountType { get;  set; }


        public string Username { get;  set; }
        public string Password { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string Prefix { get;  set; }
        public string Email { get;  set; }
        public DateTime DateOfBirth { get;  set; }
        public string Nationality { get;  set; }
        public Address Address { get;  set; }
        public Gender Gender { get;  set; }


        public Employee(
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
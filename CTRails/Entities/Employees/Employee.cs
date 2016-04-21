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


        /// <summary>
        /// Creates an employee.
        /// </summary>
        /// <param name="id"> The employee id number. </param>
        /// <param name="accountType"> Specifies the employee's account type. </param>
        /// <param name="username"> Specifies the employee's username. </param>
        /// <param name="password"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="prefix"></param>
        /// <param name="email"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="nationality"></param>
        /// <param name="address"></param>
        /// <param name="gender"></param>
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


        public Employee(
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
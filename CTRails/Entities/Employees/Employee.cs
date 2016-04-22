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
        public int AccountTypeID { get;  set; }


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
        /// <param name="accountTypeID"> Specifies the employee's account type. </param>
        /// <param name="username"> Specifies the employee's username. </param>
        /// <param name="password"> Specifies the employee's password. </param>
        /// <param name="firstName"> Specifies the employee's first name. </param>
        /// <param name="lastName"> Specifies the employee's last name. </param>
        /// <param name="prefix"> Specifies the employee's prefix. </param>
        /// <param name="email"> Specifies the employee's email address. </param>
        /// <param name="dateOfBirth"> Specifies the employee's date of birth. </param>
        /// <param name="nationality"> Specifies the employee's nationality </param>
        /// <param name="address"> Specifies the employee's home address. </param>
        /// <param name="gender"> Specifies the employee's gender. </param>
        public Employee(
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
            : base(id)
        {
            AccountTypeID = accountTypeID;
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


        /// <summary>
        /// Creates an employee.
        /// </summary>
        /// <param name="accountTypeID"> Specifies the employee's account type. </param>
        /// <param name="username"> Specifies the employee's username. </param>
        /// <param name="password"> Specifies the employee's password. </param>
        /// <param name="firstName"> Specifies the employee's first name. </param>
        /// <param name="lastName"> Specifies the employee's last name. </param>
        /// <param name="prefix"> Specifies the employee's prefix. </param>
        /// <param name="email"> Specifies the employee's email address. </param>
        /// <param name="dateOfBirth"> Specifies the employee's date of birth. </param>
        /// <param name="nationality"> Specifies the employee's nationality </param>
        /// <param name="address"> Specifies the employee's home address. </param>
        /// <param name="gender"> Specifies the employee's gender. </param>
        public Employee(
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
        {
            AccountTypeID = accountTypeID;
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
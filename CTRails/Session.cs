using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTRails.DAL;
using CTRails.Entities.Employees;
using CTRails.Exceptions;


namespace CTRails
{
    public static class Session
    {

        public static Employee User { get; internal set; }
        public static bool Started { get; internal set; }


        public static bool Start(Employee employee)
        {

            UnitOfWork worker = new UnitOfWork(true);

            // If the user does not exist.
            if (worker.Employees.Get().All(user => user.ID != employee.ID))
                throw new EntityNotPresentException("Cannot start a session with an unregistered employee.");

            ToAccountType(ref employee);

            User = employee;

            Started = true;

            return true;
        }



        public static void End()
        {
            User = null;
            Started = false;
        }



        public static void ToAccountType(ref Employee employee)
        {
            if (employee.AccountType.Name == "Administrator")
                employee = new Administrator(employee.ID, employee.AccountType, employee.Username, employee.Password, employee.FirstName, employee.LastName, employee.Prefix, employee.Email, employee.DateOfBirth, employee.Nationality, employee.Address, employee.Gender);
            else if (employee.AccountType.Name == "FleetAdministrator")
                employee = new FleetAdministrator(employee.ID, employee.AccountType, employee.Username, employee.Password, employee.FirstName, employee.LastName, employee.Prefix, employee.Email, employee.DateOfBirth, employee.Nationality, employee.Address, employee.Gender);
            else if (employee.AccountType.Name == "Driver")
                employee = new Driver(employee.ID, employee.AccountType, employee.Username, employee.Password, employee.FirstName, employee.LastName, employee.Prefix, employee.Email, employee.DateOfBirth, employee.Nationality, employee.Address, employee.Gender);
            else if (employee.AccountType.Name == "Janitor")
                employee = new Janitor(employee.ID, employee.AccountType, employee.Username, employee.Password, employee.FirstName, employee.LastName, employee.Prefix, employee.Email, employee.DateOfBirth, employee.Nationality, employee.Address, employee.Gender);
            else if (employee.AccountType.Name == "LeadJanitor")
                employee = new LeadJanitor(employee.ID, employee.AccountType, employee.Username, employee.Password, employee.FirstName, employee.LastName, employee.Prefix, employee.Email, employee.DateOfBirth, employee.Nationality, employee.Address, employee.Gender);
            else if (employee.AccountType.Name == "Technician")
                employee = new Technicus(employee.ID, employee.AccountType, employee.Username, employee.Password, employee.FirstName, employee.LastName, employee.Prefix, employee.Email, employee.DateOfBirth, employee.Nationality, employee.Address, employee.Gender);
            else 
                employee = new LeadTechnician(employee.ID, employee.AccountType, employee.Username, employee.Password, employee.FirstName, employee.LastName, employee.Prefix, employee.Email, employee.DateOfBirth, employee.Nationality, employee.Address, employee.Gender);
        }
    }
}

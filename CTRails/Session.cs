using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTRails.DAL;
using CTRails.Entities;
using CTRails.Entities.Employees;
using CTRails.Events;
using CTRails.Exceptions;


namespace CTRails
{

    public static class Session
    {
        public delegate void UserLoggedInHandler(SessionEventArgs e);
        public delegate void UserLoggedOutHandler(SessionEventArgs e);
        public static event UserLoggedInHandler UserLoggedIn;
        public static event UserLoggedInHandler UserLoggedOut;

        public static Employee User { get; internal set; }
        public static bool Started { get; internal set; }


        public static bool Start(Employee employee)
        {

            UnitOfWork worker = new UnitOfWork(false);

            // If the user does not exist.
            if (worker.Employees.Get().All(user => user.ID != employee.ID))
                throw new EntityNotPresentException("Cannot start a session with an unregistered employee.");

            ToAccountType(ref employee);

            User = employee;

            Started = true;

            UserLoggedIn(new SessionEventArgs(User));

            return true;
        }



        public static void End()
        {
            UserLoggedOut(new SessionEventArgs(User));
            User = null;
            Started = false;
        }



        public static void ToAccountType(ref Employee employee)
        {

            UnitOfWork worker = new UnitOfWork(false);

            foreach (AccountType t in worker.AccountTypes.Get())
            {
                if (t.ID == employee.AccountTypeID)
                {
                    if (t.Name == "Administrator")
                        employee = new Administrator(employee.ID, employee.AccountTypeID, employee.Username, employee.Password, employee.FirstName, employee.LastName, employee.Prefix, employee.Email, employee.DateOfBirth, employee.Nationality, employee.Address, employee.Gender);
                    else if (t.Name == "FleetAdministrator")
                        employee = new FleetAdministrator(employee.ID, employee.AccountTypeID, employee.Username, employee.Password, employee.FirstName, employee.LastName, employee.Prefix, employee.Email, employee.DateOfBirth, employee.Nationality, employee.Address, employee.Gender);
                    else if (t.Name == "Driver")
                        employee = new Driver(employee.ID, employee.AccountTypeID, employee.Username, employee.Password, employee.FirstName, employee.LastName, employee.Prefix, employee.Email, employee.DateOfBirth, employee.Nationality, employee.Address, employee.Gender);
                    else if (t.Name == "Janitor")
                        employee = new Janitor(employee.ID, employee.AccountTypeID, employee.Username, employee.Password, employee.FirstName, employee.LastName, employee.Prefix, employee.Email, employee.DateOfBirth, employee.Nationality, employee.Address, employee.Gender);
                    else if (t.Name == "LeadJanitor")
                        employee = new LeadJanitor(employee.ID, employee.AccountTypeID, employee.Username, employee.Password, employee.FirstName, employee.LastName, employee.Prefix, employee.Email, employee.DateOfBirth, employee.Nationality, employee.Address, employee.Gender);
                    else if (t.Name == "Technician")
                        employee = new Technician(employee.ID, employee.AccountTypeID, employee.Username, employee.Password, employee.FirstName, employee.LastName, employee.Prefix, employee.Email, employee.DateOfBirth, employee.Nationality, employee.Address, employee.Gender);
                    else
                        employee = new LeadTechnician(employee.ID, employee.AccountTypeID, employee.Username, employee.Password, employee.FirstName, employee.LastName, employee.Prefix, employee.Email, employee.DateOfBirth, employee.Nationality, employee.Address, employee.Gender);
                }
            }
        }
    }
}

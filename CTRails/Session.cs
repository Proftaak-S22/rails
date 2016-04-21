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


            User = employee;
            Started = true;

            return true;
        }



        public static void End()
        {
            User = null;
            Started = false;
        }
    }
}

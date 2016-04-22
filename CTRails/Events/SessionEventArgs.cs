using System;
using CTRails.Entities.Employees;


namespace CTRails.Events
{

    public class SessionEventArgs : EventArgs
    {
        public Employee User { get; private set; }

        public SessionEventArgs(Employee user)
        {
            User = user;
        }

    }

}
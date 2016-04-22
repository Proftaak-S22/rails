using System;
using CTRails.Entities.Employees;


namespace CTRails.Events
{

    /// <summary>
    /// Represents log session event data.
    /// </summary>
    public class SessionEventArgs : EventArgs
    {
        public Employee User { get; private set; }

        public SessionEventArgs(Employee user)
        {
            User = user;
        }

    }

}
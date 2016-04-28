using System;
using CTRails.Entities.Employees;


namespace CTRails.Entities
{
    public class Task : Entity
    {
        //Fields
        private int taskNumber;
        public int EmployeeID { get; set; }
        public int TramID { get; set; }


        public DateTime Date { get; set; }
        public int IsDone { get; set; }


        //Constructor
        public Task(int id, int employeeID, int tramID, DateTime date, int isDone) : base(id)
        {
            EmployeeID = employeeID;
            TramID = tramID;
            Date = date;
            IsDone = isDone;
        }
    }
}

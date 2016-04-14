using System;
using CTRails.Entities.Employees;


namespace CTRails.Entities
{
    public class Task
    {
        //Fields
        private int taskNumber;
        private DateTime time;

        //Constructor
        public Task(int taskNumber, Employee user, Tram tram, DateTime time, Sector startSector, Sector endSector)
        {
            this.taskNumber = taskNumber;
            this.time = time;
        }

        //Methods
        public void RemoveTask(Task task)
        {
            
        }
    }
}

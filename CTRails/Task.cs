using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTRails.Users;


namespace CTRails
{
    class Task
    {
        private int taskNumber;
        private DateTime Time;

        public Task(int taskNumber, User user, Tram tram, DateTime time, Section startSection, Section endSection)
        {
            this.taskNumber = taskNumber;
            this.Time = time;
        }

        public void RemoveTask(Task task) { }
    }
}

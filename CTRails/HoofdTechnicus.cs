using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails
{
    class HoofdTechnicus : Technicus
    {
        public HoofdTechnicus(string name, Geslacht gender, DateTime birthdate, string email, string nationality, string username, string password) : base(name, gender, birthdate, email, nationality, username, password) { }
        public void ChangeSchedule(User user, DateTime dateTime, Tram tram) { }
    }
}

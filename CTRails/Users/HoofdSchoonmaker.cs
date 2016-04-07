using System;


namespace CTRails.Users
{
    public class HoofdSchoonmaker: Schoonmaker
    {
        public HoofdSchoonmaker(string name, Geslacht gender, DateTime birthdate, string email, string nationality, string username, string password) : base(name, gender, birthdate, email, nationality, username, password) { }
        public void ChangeSchedule(User user, DateTime datetime, Tram tram) { }
    }
}

using System;


namespace CTRails.Users
{
    public class Technicus : User
    {
        public Technicus(string name, Geslacht gender, DateTime birthdate, string email, string nationality, string username, string password) : base(name, gender, birthdate, email, nationality, username, password) { }
    }
}

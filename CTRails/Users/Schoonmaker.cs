using System;


namespace CTRails.Users
{
    class Schoonmaker : User
    {
        //Fields

        //Constructor
        public Schoonmaker(
            string name,
            Geslacht gender,
            DateTime birthdate,
            string email,
            string nationality,
            string username,
            string password
        )
        :base(name, gender, birthdate, email, nationality, username, password) { }

        //Methods

    }
}

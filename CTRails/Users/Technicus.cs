﻿using System;


namespace CTRails.Users
{
    class Technicus : User
    {
        //Fields

        //Constructor
        public Technicus(
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

﻿using System;


namespace CTRails.Users
{
    class Machinist : User
    {
        //Fields

        //Constructor
        public Machinist(string name,
            Geslacht gender, 
            DateTime birthdate, 
            string email,
            string nationality, 
            string username, 
            string password
        )
        : base(name, gender, birthdate, email, nationality, username, password) { }

        //Methods
        public void EditTramNumber(Tram tram)
        {
            
        }
    }
}

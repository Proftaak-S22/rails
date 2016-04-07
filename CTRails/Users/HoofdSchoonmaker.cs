using System;


namespace CTRails.Users
{
    class HoofdSchoonmaker: Schoonmaker
    {
        //Fields

        //Constructor
        public HoofdSchoonmaker(
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
        public void ChangeSchedule(User user, DateTime datetime, Tram tram)
        {
            
        }
    }
}

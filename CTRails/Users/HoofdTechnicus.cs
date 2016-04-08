using System;


namespace CTRails.Users
{
    public class HoofdTechnicus : Technicus
    {
        //Fields

        //Constructor
        public HoofdTechnicus(
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
        public void ChangeSchedule(Employee user, DateTime dateTime, Tram tram)
        {
            
        }
    }
}

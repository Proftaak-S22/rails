using System;


namespace CTRails.Users
{
    public class WagenParkBeheerder : User
    {
        //Fields

        //Constructor
        public WagenParkBeheerder(string name,
            Geslacht gender, 
            DateTime birthdate,
            string email,
            string nationality,
            string username,
            string password
        ) 
        : base(name, gender, birthdate, email, nationality, username, password) { }

        //Methods
        public void GetTramLocatie(Tram tram)
        {
            
        }

        public void BlockSection(Section section)
        {
            
        }
    }
}

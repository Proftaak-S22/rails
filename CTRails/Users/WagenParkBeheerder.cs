using System;


namespace CTRails.Users
{
    public class WagenParkBeheerder : User
    {
        public WagenParkBeheerder(string name, Geslacht gender, DateTime birthdate, string email, string nationality, string username, string password) : base(name, gender, birthdate, email, nationality, username, password) { }
        public void GetTramLocatie(Tram tram) { }
        public void BlockSection(Section section) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails
{
    class Beheerder : User
    {
        public Beheerder(string name, Geslacht gender, DateTime birthdate, string email, string nationality, string username, string password) : base(name, gender, birthdate, email, nationality, username, password) { }
        public void DeleteTram(Tram tram) { }
        public void AddTram(int tramNumber, Status status) { }
        public void AddAccount(string name, Geslacht gender, DateTime birthDate, Adres adres, string email, string nationality, string userName, string password) { }
        public void VerwijderAccount(User user) { }
    }
}

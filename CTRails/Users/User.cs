using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Users
{
    public class User
    {
        private string name;
        private Geslacht gender;
        private DateTime birthdate;
        private string email;
        private string nationality;
        private string username;
        private string password;

        public User(string name, Geslacht gender, DateTime birthdate, string email, string nationality, string username, string password)
        {
            this.name = name;
            this.gender = gender;
            this.birthdate = birthdate;
            this.email = email;
            this.nationality = nationality;
            this.username = username;
            this.password = password;
            //lskadjflkasdjflkasjdflkasjdf
        }

        public void EditUser(User user) { }
        public void RemoveUser(User user) { }
        public void ChangeUser(string userpassword, string password) { }
    }
}
public enum Geslacht { }
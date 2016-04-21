using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTRails.DAL;
using CTRails.Entities.Employees;


namespace CTRails
{
    public partial class LoginTabPage : TabPage
    {

        public LoginTabPage()
        {
            InitializeComponent();
        }

        public LoginTabPage(string text) : base(text)
        {
            InitializeComponent();
        }



        public bool Login(string username, string password)
        {
            UnitOfWork worker = new UnitOfWork(true);

            // Get the first employee that matches the username/password combination, or null.
            Employee user = worker.Employees.Get().FirstOrDefault(x => x.Username == username && x.Password == password);

            // No matches?
            if (user == null)
                return false;

            return Session.Start(user);
        }
    }
}

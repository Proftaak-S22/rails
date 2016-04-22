using System.Linq;
using System.Windows.Forms;
using CTRails.DAL;
using CTRails.Entities.Employees;


namespace CTRails.Controls
{
    public partial class LoginWindow : UserControl
    {

        public LoginWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Attempts to login a user by the specified username and password combination.
        /// </summary>
        /// <param name="username"> Specifies the username. </param>
        /// <param name="password"> Specifies the password. </param>
        /// <returns></returns>
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


        /// <summary>
        /// Logout the currently logged in user.
        /// </summary>
        /// <returns></returns>
        public bool Logout()
        {
            if (!Session.Started)
                return true;

            Session.End();

            return true;
        }

        private void loginClick(object sender, System.EventArgs e)
        {
            if (Login(tbUsername.Text, tbPassword.Text))
            {
                
                return;
            }

            tbPassword.Text = string.Empty;

            MessageBox.Show("Gebruikersnaam of wachtwoord is verkeerd");
        }
    }
}

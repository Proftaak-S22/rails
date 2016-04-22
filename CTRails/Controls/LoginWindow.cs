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
        /// Makes a login attempt with the given credentials.
        /// </summary>
        /// <param name="username"> Specifies the username. </param>
        /// <param name="password"> Specifies the password. </param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            UnitOfWork worker = new UnitOfWork(false);

            // Get the first employee that matches the username/password combination.
            Employee user = worker.Employees.Get().FirstOrDefault(x => x.Username == username && x.Password == password);

            // No matches?
            if (user == null)
                return false;

            return Session.Start(user);
        }


        
        public void Logout()
        {
            if (!Session.Started)
                return;

            Session.End();
        }


        private void LoginClick(object sender, System.EventArgs e)
        {
            if (!Login(tbUsername.Text, tbPassword.Text))
            {
                tbPassword.Text = string.Empty;

                MessageBox.Show("Gebruikersnaam of wachtwoord is verkeerd");
            }
        }
    }
}

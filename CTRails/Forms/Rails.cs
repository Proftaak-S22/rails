using System;
using System.Windows.Forms;
using CTRails.DAL;
using CTRails.Entities.Employees;
using CTRails.Events;
using MaterialSkin;
using MaterialSkin.Controls;


namespace CTRails.Forms
{
    public partial class Rails : MaterialForm
    {
        private UnitOfWork worker;

        public Rails()
        {
            InitializeComponent();

            FormLoading();

            Session.UserLoggedIn += OnUserLogin;
            Session.UserLoggedOut += OnUserLogout;
        }




        private void OnUserLogout(SessionEventArgs e)
        {
            btnLogOut.Visible = false;

            tcNavigation.TabPages.Clear();
            tcNavigation.TabPages.Add(tpLogin);
        }



        private void OnUserLogin(SessionEventArgs e)
        {
            btnLogOut.Visible = true;
            Text = "Welkom " + Session.User.FirstName;
            buildTabPageForUser(e.User);
        }



        private void FormLoading()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE);

            tcNavigation.TabPages.Clear();
            tcNavigation.TabPages.Add(tpLogin);
        }



        /// <summary>
        /// Constructs the tab page control based on the given user's permissions.
        /// </summary>
        /// <param name="user"> Specifies the user to generate the control by. </param>
        private void buildTabPageForUser(Employee user)
        {
            tcNavigation.TabPages.Remove(tpLogin);

            if (user.GetType() == typeof (Janitor))
            {
                tcNavigation.TabPages.Add(tpSchedule);
            }
            if (user.GetType() == typeof (LeadJanitor))
            {
                tcNavigation.TabPages.Add(tpSchedule);
                tcNavigation.TabPages.Add(tpRoosterEdit);
            }
            if (user.GetType() == typeof (Technician))
            {
                tcNavigation.TabPages.Add(tpSchedule);
            }
            if (user.GetType() == typeof (LeadTechnician))
            {
                tcNavigation.TabPages.Add(tpSchedule);
                tcNavigation.TabPages.Add(tpRoosterEdit);
            }

            if (user.GetType() == typeof (FleetAdministrator))
            {
                tcNavigation.TabPages.Add(tpRemise);
                tcNavigation.TabPages.Add(tpTrams);
            }

            if (user.GetType() == typeof(Administrator))
            {
                tcNavigation.TabPages.Add(tpRemise);
                tcNavigation.TabPages.Add(tpTrams);
                tcNavigation.TabPages.Add(tpGebruikers);
            }

        }

        private void BtnLogoutClick(object sender, EventArgs e)
        {
            loginWindow.Logout();
        }
    }
}

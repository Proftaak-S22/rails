using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CTRails.DAL;
using CTRails.Entities;
using CTRails.Entities.Employees;
using MaterialSkin;
using MaterialSkin.Controls;


namespace CTRails
{
    public partial class Rails : MaterialForm
    {
        private UnitOfWork worker;

        public Rails()
        {
            InitializeComponent();

            FormLoading();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Attempt a login with the user specified u/p combo.
            if (tpLogin.Login(txtUsername.Text, txtPassword.Text))
            {
                this.Text = "Welkom " + Session.User.FirstName;
                
                btnLogOut.Visible = true;

                // Construct the tab page control according to the user.
                BuildTabPageForUser(Session.User);

                return;
            }

            txtPassword.Text = string.Empty;
            MessageBox.Show("Gebruikersnaam of wachtwoord is verkeerd");
        }

        private void pbPlattegrond_Click(object sender, EventArgs e)
        {
            if (pbPlattegrond.Dock == DockStyle.None)
            {
                pbPlattegrond.Dock = DockStyle.Fill;
                lblVergroot.Visible = false;
            }
            else
            {
                pbPlattegrond.Dock = DockStyle.None;
                lblVergroot.Visible = true;
            }
        }

        private void SectorClick(object sender, EventArgs e)
        {
            TramPlaatsenForm popAddTram = new TramPlaatsenForm();
            string senderName = ((Label)sender).Name;

            if (popAddTram.ShowDialog() == DialogResult.OK)
            {
                ((Label)sender).Text = popAddTram.txtTramNummer.Text;
            }
        }



        /// <summary>
        /// Constructs the tab page control based on the given user's permissions.
        /// </summary>
        /// <param name="user"> Specifies the user to generate the control by. </param>
        private void BuildTabPageForUser(Employee user)
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

        private void btnLogoutClick(object sender, EventArgs e)
        {
            tpLogin.Logout();

            tcNavigation.TabPages.Clear();
            tcNavigation.TabPages.Add(tpLogin);
        }
    }
}

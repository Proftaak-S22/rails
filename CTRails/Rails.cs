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
        public string TramNummer { get; set; }
        private UnitOfWork unit;
        
        private bool addListeners = false;

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

            tabTabs.TabPages.Remove(tpLijnen);
            tabTabs.SelectedIndex = tabTabs.TabPages.IndexOf(tpLogin);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tpLogin.Login(txtUsername.Text, txtPassword.Text))
            {
                this.Text = "Welkom " + Session.User.FirstName;
                tabTabs.SelectedIndex = tabTabs.TabPages.IndexOf(tpRemise);
                tsTabs.BaseTabControl = tabTabs;
                tabTabs.TabPages.Remove(tpLogin);
                btnLogOut.Visible = true;

                MessageBox.Show(Session.User.GetType().ToString());
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
    }
}

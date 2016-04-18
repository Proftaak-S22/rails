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
    public partial class Form1 : MaterialForm
    {

        private UnitOfWork unit;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
                
            unit = new UnitOfWork();

            List<AttachedTrack> at = unit.AttachedTracks.Get().ToList();
            foreach (AttachedTrack t in at)
            {
                Console.WriteLine(t.Track + " attached to: " + t.Attached);
            }

            unit.Complete();

            tabTabs.SelectedIndex = 6;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Controleer of gebruikersnaam en wachtwoord correct zijn
            bool login = false;
            List<Employee> employees = unit.Employees.Get().ToList();
            foreach (Employee em in employees)
            {
                if(em.Username == txtUsername.Text)
                {
                    if (em.Password == txtPassword.Text)
                    {
                        login = true;
                        //Na login, ga naar hoofdscherm
                        this.Text = "Welkom " + em.FirstName;
                        tabTabs.SelectedIndex = 0;
                        tsTabs.BaseTabControl = tabTabs;
                        tabTabs.TabPages.Remove(tpLogin);
                    }
                }
            }
            unit.Complete();
            if (login == false)
            {
                txtPassword.Text = string.Empty;
                MessageBox.Show("Gebruikersnaam of wachtwoord is verkeerd");
            }
        }

        private void tpRemise_Click(object sender, EventArgs e)
        {

        }

        private void pbPlattegrond_Click(object sender, EventArgs e)
        {
            if (pbPlattegrond.Dock == DockStyle.None)
            {
                pbPlattegrond.Dock = DockStyle.Fill;
            }
            else
            {
                pbPlattegrond.Dock = DockStyle.None;
            }
        }
    }
}

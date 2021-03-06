﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CTRails.Controls;
using CTRails.DAL;
using CTRails.Entities;
using CTRails.Entities.Employees;
using CTRails.Events;
using MaterialSkin;
using MaterialSkin.Controls;


namespace CTRails.Forms
{
    public partial class Rails : MaterialForm
    {

        UnitOfWork worker = new UnitOfWork();
        private Employee target = null;

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

            LoadEmployeesForTasks();
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
            }
            if (user.GetType() == typeof (LeadJanitor))
            {
                tcNavigation.TabPages.Add(tpRoosterEdit);
            }
            if (user.GetType() == typeof (Technician))
            {
            }
            if (user.GetType() == typeof (LeadTechnician))
            {
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
                tcNavigation.TabPages.Add(tpRoosterEdit);
            }

        }

        private void BtnLogoutClick(object sender, EventArgs e)
        {
            loginWindow.Logout();
        }

        private void loginWindow1_Load(object sender, EventArgs e)
        {

        }

        private void usersWindow1_Load(object sender, EventArgs e)
        {

        }

        private void OnRemiseClick(object sender, EventArgs e)
        {
            List<Track> tracks = worker.Tracks.Get().ToList();
            List<Entities.Sector> sectors = worker.Sectors.Get().ToList();

            foreach (Control tv in remiseWindow1.Controls)
            {
                if (tv.GetType() == typeof(TrackView))
                    ((TrackView)tv).CreateSectors(tracks, sectors);
            }
        }

        private void cbGebruikerBekijken_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbGebruikerBekijken.Text;
            id = id.Remove(id.IndexOf(" "));
            lvRoostersBekijken.Items.Clear();

            foreach (Task t in worker.Tasks.Get().ToList())
            {
                if (t.EmployeeID == Convert.ToInt32(id))
                {
                    string[] row =
                    {
                        t.TramID.ToString(),
                        t.Date.ToString(),
                        t.IsDone.ToString()
                    };

                    var item = new ListViewItem(row);

                    lvRoostersBekijken.Items.Add(item);
                }

                
            }
        }

        private void LoadEmployeesForTasks()
        {
            List<Employee> employees = worker.Employees.Get().ToList();
            foreach (Employee emp in employees)
            {
                if (emp.Prefix != "")
                {
                    cbGebruikerBekijken.Items.Add(emp.ID + " : " + emp.LastName + ", " + emp.FirstName + " " + emp.Prefix);
                }
                else
                {
                    cbGebruikerBekijken.Items.Add(emp.ID + " : " + emp.LastName + ", " + emp.FirstName);
                }
            }
        }

        private void btnBekijkRoosters1_Click(object sender, EventArgs e)
        {
            tcNavigation.SelectedIndex = tcNavigation.TabPages.IndexOf(tpRoosterEdit);
        }

        private void OnUserSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }
    }
}

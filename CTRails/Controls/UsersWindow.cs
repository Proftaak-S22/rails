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


namespace CTRails.Controls
{
    public partial class UsersWindow : UserControl
    {
        UnitOfWork worker = new UnitOfWork(true);

        public UsersWindow()
        {
            InitializeComponent();

            LoadUsers();
        }



        private void LoadUsers()
        {
            

            lvGebruikers.Items.Clear();

            foreach (Employee e in worker.Employees.Get())
            {
                string[] row =
                {
                    e.Username,
                    e.Gender.ToString(),
                    e.FirstName + " " + e.Prefix + " " + e.LastName,
                    e.DateOfBirth.ToShortDateString(),
                    e.Email ,
                    e.Address.Country ,
                    e.Address.City,
                    e.Address.Zipcode,
                    e.Address.Number.ToString()
                };

                var item = new ListViewItem(row);

                lvGebruikers.Items.Add(item);
            }
        }

        private void OnUserSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            Employee selection = worker.Employees.Get().First(x => x.Email == e.Item.SubItems[4].Text);

            tbUsername.Text = selection.Username;
            tbPassword.Text = selection.Password;
            tbEmail.Text = selection.Email;
            tbFirstname.Text = selection.FirstName;
            tbPrefix.Text = selection.Prefix;
            tbLastName.Text = selection.LastName;
            tbCountry.Text = selection.Address.Country;
            tbZipcode.Text = selection.Address.Zipcode;
            tbHouseNumber.Text = selection.Address.Number.ToString();
            dtpDateOfBirth.Value = selection.DateOfBirth;
            cbGender.SelectedIndex = cbGender.Items.IndexOf(selection.Gender.ToString());
            tbCountry.Text = selection.Address.Country;
        }
    }
}

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
        UnitOfWork worker = new UnitOfWork(false);

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

            SetTextboxValues(selection.Username, selection.Password, selection.Email, selection.FirstName, selection.Prefix, selection.LastName, selection.Address.Country, selection.Address.Zipcode, selection.Address.Number, selection.DateOfBirth, selection.Gender, selection.Address.City);
        }



        private void SetTextboxValues(string username, string password, string email, string firstname, string prefix, string lastname, string country, string zipcode, int number, DateTime date, Gender gender, string city)
        {
            tbUsername.Text = username;
            tbPassword.Text = password;
            tbEmail.Text = email;
            tbFirstname.Text = firstname;
            tbPrefix.Text = prefix;
            tbLastName.Text = lastname;
            tbCountry.Text = country;
            tbZipcode.Text = zipcode;
            tbHouseNumber.Text = number.ToString();
            dtpDateOfBirth.Value = date;
            cbGender.SelectedIndex = cbGender.Items.IndexOf(gender.ToString());
            tbCity.Text = city;
        }

        private void OnDeleteUserClick(object sender, EventArgs e)
        {

        }

        private void OnAddUserClick(object sender, EventArgs e)
        {

        }

        private void OnUpdateUserClick(object sender, EventArgs e)
        {

        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

        private Employee target = null;

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
            
            target = worker.Employees.Get().First(x => x.Email == e.Item.SubItems[4].Text);

            SetTextboxValues(target.Username, target.Password, target.Email, target.FirstName, target.Prefix, target.LastName, target.Address.Country, target.Address.Zipcode, target.Address.Number, target.DateOfBirth, target.Gender, target.Address.City);
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

            target.FirstName = tbFirstname.Text;
            target.Gender = (Gender) Enum.Parse(typeof (Gender), cbGender.Text);
            target.Password = tbPassword.Text;
            target.Address.Number = Convert.ToInt32(tbHouseNumber.Text);
            target.Address.City = tbCountry.Text;
            target.LastName = tbLastName.Text;
            target.Address.Zipcode = tbZipcode.Text;
            target.Username = tbUsername.Text;

            if (target != null)
                worker.Employees.Update(target);
        }

        
    }
}

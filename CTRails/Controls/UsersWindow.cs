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
        public UsersWindow()
        {
            InitializeComponent();

            LoadUsers();
        }



        private void LoadUsers()
        {
            UnitOfWork worker = new UnitOfWork(true);

            foreach (Employee e in worker.Employees.Get())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(e.Username);
                item.SubItems.Add(e.Gender.ToString());
                item.SubItems.Add(e.DateOfBirth.ToShortDateString());
                item.SubItems.Add(e.FirstName + " " + e.Prefix + " " + e.LastName);
                item.SubItems.Add(e.Email);
                item.SubItems.Add(e.Address.Country);
                item.SubItems.Add(e.Address.City);
                item.SubItems.Add(e.Address.Zipcode);
                item.SubItems.Add(e.Address.Number.ToString());

                lvGebruikers.Items.Add(item);
            }
        }
    }
}

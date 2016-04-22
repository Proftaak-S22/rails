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
    }
}

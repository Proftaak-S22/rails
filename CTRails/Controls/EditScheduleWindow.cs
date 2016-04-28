using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTRails;
using CTRails.DAL;
using CTRails.Entities.Employees;


namespace CTRails.Controls
{
    public partial class EditScheduleWindow : UserControl
    {
        UnitOfWork worker = new UnitOfWork();

        public Type AccountType { get; private set; }

        public EditScheduleWindow()
        {
            InitializeComponent();
            LoadEmployeesForTasks();
        }

        private void LoadEmployeesForTasks()
        {
            List<Employee> employees = worker.Employees.Get().ToList();
            foreach (Employee emp in employees)
            {
                if (emp.Prefix != "")
                {
                    cbGebruikerEdit.Items.Add(emp.ID + " : " + emp.LastName + ", " + emp.FirstName + " " + emp.Prefix);
                }
                else
                {
                    cbGebruikerEdit.Items.Add(emp.ID + " : " + emp.LastName + ", " + emp.FirstName);
                }
            }
        }

        public bool Initialize(Employee accountType)
        {
            if (accountType.GetType() == typeof (Janitor) || accountType.GetType() == typeof(Technician))
            {
                AccountType = accountType.GetType();
                return true;
            }

            return false;
        }

        private void cbGebruikerEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbGebruikerEdit.Text;
            id = id.Remove(id.IndexOf(" "));
            lvRoostersWijzigen.Items.Clear();

            foreach (CTRails.Entities.Task t in worker.Tasks.Get().ToList())
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

                    lvRoostersWijzigen.Items.Add(item);
                }
            }
        }
    }
}

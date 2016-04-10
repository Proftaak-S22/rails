using System;
using System.Linq;
using System.Windows.Forms;
using CTRails.Data;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails
{
    public partial class Form1 : Form
    {

        private UnitOfWork unit;

        public Form1()
        {
            InitializeComponent();

            unit = new UnitOfWork(new OracleDataContext());

            foreach (Employee e in unit.Employees.GetAll())
                Console.WriteLine(e.FirstName + " " + e.LastName);

            foreach (Status s in unit.Statuses.GetAll())
                Console.WriteLine(s.Name);

            foreach (AccountType at in unit.AccountTypes.GetAll())
                Console.WriteLine(at.Name);
        }
    }
}

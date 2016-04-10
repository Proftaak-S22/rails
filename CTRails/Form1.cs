using System;
using System.Linq;
using System.Windows.Forms;
using CTRails.Data;
using CTRails.Entities.Employees;


namespace CTRails
{
    public partial class Form1 : Form
    {

        private UnitOfWork uow;

        public Form1()
        {
            InitializeComponent();

            uow = new UnitOfWork(new OracleDataContext());
            Console.WriteLine(uow.Employees.GetAll());

            Console.WriteLine();
        }
    }
}

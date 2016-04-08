using System;
using System.Windows.Forms;
using CTRails.Data;
using CTRails.DataContexts;
using CTRails.Interfaces;


namespace CTRails
{
    public partial class Form1 : Form
    {

        private UnitOfWork uow;

        public Form1()
        {
            InitializeComponent();

            uow = new UnitOfWork(new OracleDataContext());

            IEmployeeRepository e = uow.Employees;
        }
    }
}

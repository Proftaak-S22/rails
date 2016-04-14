using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CTRails.DAL;
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

            unit = new UnitOfWork();

            Employee e = unit.Employees.Where(x => x.ID == 1).First();
            e.Email = "nhavandeursen@gmail.com";
            unit.Employees.Update(e);

            unit.Complete();
        }
    }
}

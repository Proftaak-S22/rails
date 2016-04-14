using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CTRails.DAL;
using CTRails.Entities;
using CTRails.Entities.Employees;
using MaterialSkin;
using MaterialSkin.Controls;


namespace CTRails
{
    public partial class Form1 : MaterialForm
    {

        private UnitOfWork unit;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            unit = new UnitOfWork();

            foreach (Employee e in unit.Employees.Where(x => x.Gender == Gender.M))
                Console.WriteLine(e.FirstName);

            foreach (Status s in unit.Statuses.Get())
                Console.WriteLine(s.Name);

            foreach (AccountType a in unit.AccountTypes.Get())
                Console.WriteLine(a.Name);

            unit.Complete();
        }
    }
}

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

            Employee u = new Employee(0, null, "Frits", "de Pits", "Harrie", "Gezicht", String.Empty, "ff@ff.f", DateTime.Now, "NL", new Address("De kurver", 333, "Rosmalen", "Netherland", "7777BF", "B"), Gender.F );
            u.ID = 1;
            unit.Employees.Update(u);


            Employee e = unit.Employees.Where(x => x.ID == 1).First();
            e.Email = "nhavandeursen@gmail.com";
            unit.Employees.Update(e);

            unit.Complete();
        }
    }
}

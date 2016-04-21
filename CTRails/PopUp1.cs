using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTRails.Properties;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CTRails
{
    public partial class PopUp1 : MaterialForm
    {
        public PopUp1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnAddTram_Click(object sender, EventArgs e)
        {
            //TramNummer = txtTramNummer.Text;
            this.Close();
        }
    }
}

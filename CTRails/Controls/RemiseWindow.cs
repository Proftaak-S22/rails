using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTRails.DAL;
using CTRails.Forms;


namespace CTRails.Controls
{
    public partial class RemiseWindow : UserControl
    {

        private PlaceTramForm placeTramForm;
        

        public RemiseWindow()
        {
            InitializeComponent();
        }

        private void OnSectorClick(object sender, EventArgs e)
        {
            
        }

        private void OnPlattegrondClick(object sender, EventArgs e)
        {
            if (pbPlattegrond.Dock == DockStyle.None)
            {
                pbPlattegrond.Dock = DockStyle.Fill;
                lblVergroot.Visible = false;
            }
            else
            {
                pbPlattegrond.Dock = DockStyle.None;
                lblVergroot.Visible = true;
            }
        }

        private void OnDemoClick(object sender, EventArgs e)
        {

        }
    }
}

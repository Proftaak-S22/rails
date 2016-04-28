using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTRails.Controls
{
    public partial class Sector : UserControl
    {

        public Entities.Sector SectorObject { get; set; }


        public event EventHandler ClickHandler;

        public override string Text
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }

        public Sector()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            ClickHandler?.Invoke(this, EventArgs.Empty);
        }

    }
}

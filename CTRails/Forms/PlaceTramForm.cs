using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace CTRails.Forms
{
    public partial class PlaceTramForm : MaterialForm
    {

        public bool Remise
        {
            get { return cbStatusRemise.Checked; }
        }


        public bool Clean
        {
            get { return cbStatusDefect.Checked; }
        }


        public bool Maintenaince
        {
            get { return cbStatusSchoonmaak.Checked; }
        }


        public int TramNummer
        {
            get { return Convert.ToInt32(txtTramNummer.Text); }
        }


        public PlaceTramForm()
        {
            InitializeComponent();

            btnAddTram.DialogResult = DialogResult.OK;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnAddTram_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            

            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
        public Font MaintenanceFont { get; set; }
        public Font DefaultFont { get; set; }
        public Color CleanColor { get; set; }
        public Color DefaultColor { get; set; }

        public RemiseWindow()
        {
            InitializeComponent();

            MaintenanceFont = new Font(lblSection12_1.Font.FontFamily, lblSection12_1.Font.SizeInPoints, FontStyle.Underline);
            DefaultFont = new Font(lblSection12_1.Font.FontFamily, lblSection12_1.Font.SizeInPoints, FontStyle.Regular);
            CleanColor = Color.Blue;
            DefaultColor = Color.Black;

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof (Label))
                    c.Click += OnSectorClick;
            }


        }

        private void OnSectorClick(object sender, EventArgs e)
        {
            placeTramForm = new PlaceTramForm();

            Label clickedLabel = ((Label) sender);

            if (placeTramForm.ShowDialog() == DialogResult.OK)
            {
                int code = placeTramForm.TramCode;

                UnitOfWork work = new UnitOfWork(true);

                Tram tram = work.Trams.Get().FirstOrDefault(x => x.Code == code);

                // Does the entered tram actually exist?
                if (tram == null)
                {
                    MessageBox.Show("Tram bestaat niet.");
                    return;
                }



                clickedLabel.ForeColor = placeTramForm.Clean ? CleanColor : DefaultColor;

                clickedLabel.Font = placeTramForm.Maintenaince ? MaintenanceFont : DefaultFont;

                clickedLabel.Text = placeTramForm.TramCode.ToString();
            }
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
    }
}

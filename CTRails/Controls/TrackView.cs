using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTRails.DAL;
using CTRails.DAL.Contexts;
using CTRails.Entities;
using CTRails.Exceptions;
using CTRails.Forms;


namespace CTRails.Controls
{
    public partial class TrackView : UserControl
    {

        [Category("Rails")]
        [Description("Gets/Sets the line color.")]
        [Browsable(true)]
        public Color LineColor
        {
            get { return pLine.BackColor; }
            set { pLine.BackColor = value; }
        }


        private int sectorCount = 1;

        [Category("Rails")]
        [Description("Gets/Sets the track number.")]
        [Browsable(true)]
        public int TrackNumber
        {
            get { return Convert.ToInt32(btnTrack.Text); }
            set
            {
                if (value < 1)
                    return;
                
                btnTrack.Text = value.ToString();
            }
        }


        public Sector SectorOne
        {
            get { return sectorOne; }
            set { sectorOne = value; }
        }


        public Entities.Track TrackObject { get; set; }

        public List<Sector>  Sectors { get; private set; } = new List<Sector>();

        [Category("Rails")]
        [Description("Gets/Sets the font when trams are in maintenance.")]
        [Browsable(true)]
        public Font SectorMaintenanceFont { get; set; }


        [Category("Rails")]
        [Description("Gets/Sets the font when trams are in maintenance.")]
        [Browsable(true)]
        public Font SectorDefaultFont { get; set; }


        [Category("Rails")]
        [Description("Gets/Sets the font when trams are in maintenance.")]
        [Browsable(true)]
        public Color SectorCleanColor { get; set; }


        [Category("Rails")]
        [Description("Gets/Sets the font when trams are in maintenance.")]
        [Browsable(true)]
        public Color SectorDefaultColor { get; set; }


        private PlaceTramForm tramPlacementForm;
        
        public TrackView()
        {
            InitializeComponent();

            Sectors.Add(SectorOne);
        }



        public void CreateSectors(List<Track> tracks, List<Entities.Sector> sectors  )
        {
            UnitOfWork worker = new UnitOfWork();

            TrackObject = tracks.FirstOrDefault(t => t.ID == TrackNumber);

            if (TrackObject == null)
            {
                Console.WriteLine("Track with ID " + TrackNumber + " Does not exist in the database.");
                return;
            }

            TrackObject.Sectors = sectors.Where(s => s.TrackID == TrackNumber).OrderBy(s => s.ID).ToList();


            // Remove initial controls.
            foreach (Sector c in Sectors.Where(x => x != sectorOne))
                Controls.Remove(c);


            // If no sectors, return.
            if (TrackObject.Sectors.Count < 1)
                return;

            sectorOne.SectorObject = TrackObject.Sectors[0];
            sectorOne.ClickHandler += OnSectorClick;

            for (int i = 1; i < TrackObject.Sectors.Count; i++)
            {
                Sector newSector = new Sector
                {
                    Location = new Point(sectorOne.Location.X, sectorOne.Location.Y + sectorOne.Height + (sectorOne.Height * (i - 1))),
                    SectorObject = TrackObject.Sectors[i],
                    
                };

                newSector.ClickHandler += OnSectorClick;

                Controls.Add(newSector);
            }
        }

        private void OnSectorClick(object sender, EventArgs e)
        {
            tramPlacementForm = new PlaceTramForm();
            UnitOfWork work = new UnitOfWork(false);
            Sector clicked = (Sector) sender;

            if (tramPlacementForm.ShowDialog() == DialogResult.OK)
            {
                if (tramPlacementForm.TramCode == "X" || tramPlacementForm.TramCode == "x")
                {

                    return;
                }
                if (tramPlacementForm.TramCode == string.Empty)
                {
                    clicked.Text = "...";
                    return;
                }

                Regex regex = new Regex(@"^\d+$");

                if (!regex.IsMatch(tramPlacementForm.TramCode))
                {
                    MessageBox.Show("Vul alleen tramnummers in, laat leeg voor de sector te deblokkeren of vul een 'x' in voor de sector te blokkeren.", "Syntax Error");
                    return;
                }


                int code = Convert.ToInt32(tramPlacementForm.TramCode);



                Tram tram = work.Trams.Get().FirstOrDefault(x => x.Code == code);
                



                // Does the given tram number actually exist?
                if (tram == null)
                {
                    MessageBox.Show("Tram bestaat niet.");
                    return;
                }
                clicked.SectorObject.Tram = tram;
                work.Sectors.Update(clicked.SectorObject);

                clicked.ForeColor = tramPlacementForm.Clean ? SectorCleanColor : SectorDefaultColor;

                clicked.Font = tramPlacementForm.Maintenaince ? SectorMaintenanceFont : SectorDefaultFont;

                clicked.Text = tramPlacementForm.TramCode.ToString();
            }
        }
    }
}

namespace CTRails.Entities
{
    public class Sector
    {
        //Fields
        public int SectionNumber { get; set; }
        public int TrackNumber { get; set; }

        //Constructor
        public Sector(int sectionNumber, int trackNumber)
        {
            this.SectionNumber = sectionNumber;
            this.TrackNumber = trackNumber;
        }
    }
}

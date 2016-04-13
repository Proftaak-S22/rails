namespace CTRails.Entities
{
    public class Sector
    {
        //Fields
        private int sectionNumber;
        private Track track;

        //Constructor
        public Sector(int sectionNumber, Track track)
        {
            this.sectionNumber = sectionNumber;
            this.track = track;
        }

        //Methods
        public void RemoveSection(Sector sector)
        {
            
        }
    }
}

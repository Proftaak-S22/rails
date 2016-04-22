using System.Collections.Generic;
using CTRails.DAL;


namespace CTRails.Entities
{
    public class Sector
    {
        //Fields
        public int Number { get; set; }

        public int TrackID { get; set; }

        //Constructor
        public Sector(int number, int trackId)
        {
            this.Number = number;
            this.TrackID = trackId;
        }
    }
}

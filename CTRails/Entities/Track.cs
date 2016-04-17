using System.Collections.Generic;

namespace CTRails.Entities
{
    public class Track : Entity
    {
        //Fields
        public int Number { get; private set; }


        public IEnumerable<Sector> Sectors { get; set; }


        public IEnumerable<Track> AttachedTracks { get; set; }


        public IEnumerable<Route> Routes { get; set; }


        //Constructor
        public Track(int id) : base (id)
        {

        }
    }
}

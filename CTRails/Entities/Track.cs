using System.Collections.Generic;

namespace CTRails.Entities
{
    public class Track : Entity
    {
        //Fields
        public int Number { get; private set; }
        private ICollection<Sector> sectors;
        private ICollection<Track> attached;
        private ICollection<Route> routes;

        //Constructor
        public Track(int id) : base (id)
        {

        }
    }
}

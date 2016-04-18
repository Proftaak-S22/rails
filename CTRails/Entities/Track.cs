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
/*
using CTRails.DAL;
using System;
using System.Collections.Generic;

namespace CTRails.Entities
{
    public class Track : Entity
    {
        //Fields
        private UnitOfWork unit;
        public int Number { get; private set; }
        private ICollection<Sector> sectors;
        private ICollection<Track> attached;
        private ICollection<Route> routes;
        public IEnumerable<Sector> Sectors
        {
            get
            {
                unit = new UnitOfWork();
                return unit.Sectors.Get();
            }
        }
        public IEnumerable<Track> Tracks
        {
            get
            {
                unit = new UnitOfWork();
                return unit.Tracks.Get();
            }
        }
        public IEnumerable<Route> Routes
        {
            get
            {
                unit = new UnitOfWork();
                return unit.Routes.Get();
            }
        }

        //Constructor
        public Track(int id, int number) : base(id)
        {
            Number = number;
        }

        //Methodes
        public void Update()
        {

        }
    }
}
*/

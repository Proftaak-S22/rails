using CTRails.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CTRails.Entities
{
    public class Track : Entity
    {
        //Fields
        private UnitOfWork unit;
        public int Number { get; private set; }

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
        public Track(int id) : base(id)
        {
            Number = id;
        }

        //Methoden
        public void Update()
        {
            List<Sector> sectors = Sectors.ToList();
            foreach (Sector s in sectors)
            {
                
            }
        }
    }
}


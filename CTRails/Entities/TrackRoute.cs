using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Entities.Employees
{
    class TrackRoute : Entity
    {
        //Fields
        public Track Track { get; private set; }
        public Route Route { get; private set; }
        

        //Constructor
        public TrackRoute(int id, Track track, Route route) : base(id)
        {
            Track = track;
            Route = route;
        }
    }
}

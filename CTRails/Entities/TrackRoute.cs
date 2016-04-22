using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Entities.Employees
{
    public class TrackRoute : Entity
    {
        //Fields
        public int TrackID { get; private set; }
        public int RouteID { get; private set; }
        

        //Constructor
        public TrackRoute(int trackID, int routeID) : base()
        {
            TrackID = trackID;
            RouteID = routeID;
        }
    }
}

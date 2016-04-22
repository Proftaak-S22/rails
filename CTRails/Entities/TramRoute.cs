using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Entities.Employees
{
    public class TramRoute : Entity
    {
        //Fields
        public int TramID { get; private set;}
        public int RouteID { get; private set; }

        //Constructor
        public TramRoute(int tramID, int routeID)
        {
            TramID = tramID;
            RouteID = routeID;
        }
    }
}

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
        public Tram Tram { get; private set;}
        public Route Route { get; private set; }

        //Constructor
        public TramRoute(int id, Tram tram, Route route) : base(id)
        {
            Tram = tram;
            Route = route;
        }
    }
}

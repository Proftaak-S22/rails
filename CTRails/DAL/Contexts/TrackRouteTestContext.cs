using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using CTRails.Entities;
using CTRails.Entities.Employees;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class TrackRouteTestContext : TestDatabaseContext<TrackRoute>, IDataContext<TrackRoute>
    {

        private int ID => id++;
        private int id = 0;

        public TrackRouteTestContext()
            : base()
        {
            Entities.Add(new TrackRoute(1, new Track(1), new Route(1, "A") ));
            Entities.Add(new TrackRoute(2, new Track(2), new Route(2, "B")));
            Entities.Add(new TrackRoute(3, new Track(3), new Route(3, "C")));
            Entities.Add(new TrackRoute(4, new Track(4), new Route(4, "D")));
            Entities.Add(new TrackRoute(5, new Track(5), new Route(5, "E")));
            Entities.Add(new TrackRoute(6, new Track(6), new Route(6, "F")));
        }

        public void Add(TrackRoute entity)
        {
            Entities.Add(entity);
        }



        public void Delete(TrackRoute entity)
        {
            Entities.Remove(entity);
        }



        public void Update(TrackRoute entity)
        {
            TrackRoute updated = Entities.First(x => x.ID == entity.ID);
            if (updated != null)
                updated = entity;
        }



        public IEnumerable<TrackRoute> Get()
        {
            return Entities;
        }

    }
}

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
    public class TramRouteTestContext : TestDatabaseContext<TramRoute>, IDataContext<TramRoute>
    {

        private int ID => id++;
        private int id = 0;

        public TramRouteTestContext()
            : base()
        {
            Entities.Add(new TramRoute(1, new Tram(1, 1023), new Route(1, "A") ));
            Entities.Add(new TramRoute(2, new Tram(2, 1024), new Route(2, "B")));
            Entities.Add(new TramRoute(3, new Tram(3, 1025), new Route(3, "C")));
            Entities.Add(new TramRoute(4, new Tram(4, 1026), new Route(4, "D")));
            Entities.Add(new TramRoute(5, new Tram(5, 1027), new Route(5, "E")));
        }

        public void Add(TramRoute entity)
        {
            Entities.Add(entity);
        }



        public void Delete(TramRoute entity)
        {
            Entities.Remove(entity);
        }



        public void Update(TramRoute entity)
        {
            TramRoute updated = Entities.First(x => x.ID == entity.ID);
            if (updated != null)
                updated = entity;
        }



        public IEnumerable<TramRoute> Get()
        {
            return Entities;
        }

    }
}

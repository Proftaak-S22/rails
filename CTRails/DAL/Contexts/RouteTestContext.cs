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
    public class RouteTestContext : TestDatabaseContext<Route>, IDataContext<Route>
    {

        private int ID => id++;
        private int id = 0;

        public RouteTestContext()
            : base()
        {
            Entities.Add(new Route(1, "Route 66"));
            Entities.Add(new Route(2, "Stairway to Heaven"));
            Entities.Add(new Route(3, "Bart Verminken met Bacon"));
            Entities.Add(new Route(4, ""));
            Entities.Add(new Route(5, ""));
            Entities.Add(new Route(6, ""));
            Entities.Add(new Route(7, ""));
            Entities.Add(new Route(8, ""));
            Entities.Add(new Route(9, ""));
            Entities.Add(new Route(10, ""));
        }

        public void Add(Route entity)
        {
            Entities.Add(entity);
        }



        public void Delete(Route entity)
        {
            Entities.Remove(entity);
        }



        public void Update(Route entity)
        {
            Route updated = Entities.First(x => x.ID == entity.ID);
            if (updated != null)
                updated = entity;
        }



        public IEnumerable<Route> Get()
        {
            return Entities;
        }

    }
}

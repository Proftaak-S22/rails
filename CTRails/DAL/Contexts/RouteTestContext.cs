using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using CTRails.Entities;
using CTRails.Entities.Employees;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class RouteTestContext : TestDatabaseContext<Route>, IDataContext<Route>
    {


        private int id = 0;
        private int NextID => id++;
        public RouteTestContext()
            : base()
        {
            Entities.Add(new Route(NextID, "Route 66"));
            Entities.Add(new Route(NextID, "Stairway to Heaven"));
            Entities.Add(new Route(NextID, "Bart Verminken met Bacon"));
            Entities.Add(new Route(NextID, ""));
            Entities.Add(new Route(NextID, ""));
            Entities.Add(new Route(NextID, ""));
            Entities.Add(new Route(NextID, ""));
            Entities.Add(new Route(NextID, ""));
            Entities.Add(new Route(NextID, ""));
            Entities.Add(new Route(NextID, ""));
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

using System;
using System.Collections.Generic;
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
            Entities.Add(new TramRoute(1, 2));
        }

        public TramRouteTestContext(IEnumerable<Tram> trams, IEnumerable<Route> routes  )
            : base()
        {

            
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

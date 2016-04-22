using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using CTRails.Entities;
using CTRails.Entities.Employees;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class TrackRouteTestContext : TestDatabaseContext<TrackRoute>, IDataContext<TrackRoute>
    {

        public TrackRouteTestContext()
            : base()
        {
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

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
    public class TrackTestContext : TestDatabaseContext<Track>, IDataContext<Track>
    {

        private int id = 0;
        private int NextID => id++;
        public TrackTestContext()
            : base()
        {
            for (int i = 0; i < 100; i++)
                Entities.Add(new Track(NextID));


        }

        public void Add(Track entity)
        {
            Entities.Add(entity);
        }



        public void Delete(Track entity)
        {
            Entities.Remove(entity);
        }



        public void Update(Track entity)
        {
            Track updated = Entities.First(x => x.ID == entity.ID);
            if (updated != null)
                updated = entity;
        }



        public IEnumerable<Track> Get()
        {
            return Entities;
        }

    }
}

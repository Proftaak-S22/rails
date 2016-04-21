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

        private int ID => id++;
        private int id = 0;

        public TrackTestContext()
            : base()
        {
            Entities.Add(new Track(1));
            Entities.Add(new Track(2));
            Entities.Add(new Track(3));
            Entities.Add(new Track(4));
            Entities.Add(new Track(5));
            Entities.Add(new Track(6));
            Entities.Add(new Track(7));
            Entities.Add(new Track(8));
            Entities.Add(new Track(9));
            Entities.Add(new Track(10));
            Entities.Add(new Track(11));
            Entities.Add(new Track(12));
            Entities.Add(new Track(13));
            Entities.Add(new Track(14));
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

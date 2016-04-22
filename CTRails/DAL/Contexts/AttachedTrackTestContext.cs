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
    public class AttachedTrackTestContext : TestDatabaseContext<AttachedTrack>, IDataContext<AttachedTrack>
    {

        public AttachedTrackTestContext()
            : base()
        {

        }

        public void Add(AttachedTrack entity)
        {
            Entities.Add(entity);
        }



        public void Delete(AttachedTrack entity)
        {
            Entities.Remove(entity);
        }



        public void Update(AttachedTrack entity)
        {
            AttachedTrack updated = Entities.First(x => x.ID == entity.ID);
            if (updated != null)
                updated = entity;
        }



        public IEnumerable<AttachedTrack> Get()
        {
            return Entities;
        }

    }
}

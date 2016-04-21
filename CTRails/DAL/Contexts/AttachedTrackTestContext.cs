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

        private int ID => id++;
        private int id = 0;

        public AttachedTrackTestContext()
            : base()
        {
            /*Entities.Add(new AttachedTrack());
            Entities.Add(new AttachedTrack(2, "Administrator"));
            Entities.Add(new AttachedTrack(3, "Janitor"));
            Entities.Add(new AttachedTrack(4, "LeadJanitor"));
            Entities.Add(new AttachedTrack(5, "Technician"));
            Entities.Add(new AttachedTrack(6, "LeadTechnician"));
            Entities.Add(new AttachedTrack(7, "Driver"));*/
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

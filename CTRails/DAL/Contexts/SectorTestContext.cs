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
    public class SectorTestContext : TestDatabaseContext<Sector>, IDataContext<Sector>
    {


        private int id = 0;
        private int NextID => id++;
        public SectorTestContext()
            : base()
        {
            for (int i = 0; i < 100; i++)
                Entities.Add(new Sector(NextID, i / 4));
        }

        public void Add(Sector entity)
        {
            Entities.Add(entity);
        }



        public void Delete(Sector entity)
        {
            Entities.Remove(entity);
        }



        public void Update(Sector entity)
        {
            Sector updated = Entities.First(x => x.Number == entity.Number);
            if (updated != null)
                updated = entity;
        }



        public IEnumerable<Sector> Get()
        {
            return Entities;
        }

    }
}

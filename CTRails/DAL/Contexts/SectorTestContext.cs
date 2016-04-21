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

        private int ID => id++;
        private int id = 0;

        public SectorTestContext()
            : base()
        {
            Entities.Add(new Sector(1, 1));
            Entities.Add(new Sector(2, 1));
            Entities.Add(new Sector(3, 1));
            Entities.Add(new Sector(4, 1));


            Entities.Add(new Sector(5, 2));
            Entities.Add(new Sector(6, 2));
            Entities.Add(new Sector(7, 2));
            Entities.Add(new Sector(8, 2));

            Entities.Add(new Sector(9, 3));
            Entities.Add(new Sector(10, 3));
            Entities.Add(new Sector(11, 3));
            Entities.Add(new Sector(12, 3));
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
            Sector updated = Entities.First(x => x.SectionNumber == entity.SectionNumber);
            if (updated != null)
                updated = entity;
        }



        public IEnumerable<Sector> Get()
        {
            return Entities;
        }

    }
}

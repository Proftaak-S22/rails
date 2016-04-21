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
    public class TramTestContext : TestDatabaseContext<Tram>, IDataContext<Tram>
    {

        private int ID => id++;
        private int id = 0;

        public TramTestContext()
            : base()
        {

        }

        public void Add(Tram entity)
        {
            Entities.Add(entity);
        }



        public void Delete(Tram entity)
        {
            Entities.Remove(entity);
        }



        public void Update(Tram entity)
        {
            Tram updated = Entities.First(x => x.ID == entity.ID);
            if (updated != null)
                updated = entity;
        }



        public IEnumerable<Tram> Get()
        {
            return Entities;
        }

    }
}

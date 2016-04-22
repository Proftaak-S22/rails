using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using CTRails.Entities;
using CTRails.Entities.Employees;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class TramTestContext : TestDatabaseContext<Tram>, IDataContext<Tram>
    {


        private int id = 0;
        private int NextID => id++;
        private int code = 1;

        public TramTestContext()
            : base()
        {
            for (int i = 0; i < 75; i++)
                Entities.Add(new Tram(NextID, code++));
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

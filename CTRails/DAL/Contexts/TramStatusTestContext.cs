using System;
using System.Collections.Generic;
using System.Linq;
using CTRails.Entities;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class TramStatusTestContext : TestDatabaseContext<TramStatus>, IDataContext<TramStatus>
    {

        public TramStatusTestContext()
            : base()
        {
            
            
        }

        public void Add(TramStatus entity)
        {
            Entities.Add(entity);
        }



        public void Delete(TramStatus entity)
        {
            Entities.Remove(entity);
        }



        public void Update(TramStatus entity)
        {
            TramStatus updated = Entities.First(x => x.ID == entity.ID);
            if (updated != null)
                updated = entity;
        }



        public IEnumerable<TramStatus> Get()
        {
            return Entities;
        }

    }
}

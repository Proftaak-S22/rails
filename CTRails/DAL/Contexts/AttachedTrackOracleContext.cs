using System;
using System.Collections.Generic;
using System.Linq;
using CTRails.Entities;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class AttachedTrackOracleContext : OracleDatabaseContext, IDataContext<AttachedTrack>
    {

        public AttachedTrackOracleContext()
            : base()
        {
            
        }

        public void Add(AttachedTrack entity)
        {
            throw new NotImplementedException();
        }



        public void Delete(AttachedTrack entity)
        {
            throw new NotImplementedException();
        }



        public void Update(AttachedTrack entity)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<AttachedTrack> Get()
        {
            Connection.Open();

            OracleCommand command = new OracleCommand("SELECT * FROM TRM_TRACK", Connection);

            OracleDataReader reader = command.ExecuteReader();

            List<AttachedTrack> attachedTracks = new List<AttachedTrack>();

            UnitOfWork uow = new UnitOfWork();

            while (reader.Read())
            {
                Track a = uow.Tracks.Where(x => x.ID == Convert.ToInt32(reader["TRACK_ID"])).First();
                Track b = uow.Tracks.Where(x => x.ID == Convert.ToInt32(reader["NEXTTRACK_ID"])).First();

                AttachedTrack next = new AttachedTrack(0, a, b);

                attachedTracks.Add(next);
            }

            return attachedTracks;
        }

    }
}

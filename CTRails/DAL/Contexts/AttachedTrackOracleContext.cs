﻿using System;
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
            OpenConnection();
            OracleCommand cmd = new OracleCommand("INSERT INTO TRM_ATTACHEDTRACK (TRACK_ID, NEXTTRACK_ID) VALUES(" + entity.Track + ", " + entity.Attached + ")", Connection);
            CloseConnection();
        }



        public void Delete(AttachedTrack entity)
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand("DELETE FROM TRM_ATTACHEDTRACK WHERE TRACK_ID = " + entity.Track + " AND NEXTTRACK_ID = " + entity.Attached, Connection);
            CloseConnection();
        }



        public void Update(AttachedTrack entity)
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand("UPDATE TRM_ATTACHEDTRACK SET NEXTTRACK_ID = " + entity.Attached + " WHERE TRACK_ID = " + entity.Track, Connection);
            CloseConnection();
        }


        public IEnumerable<AttachedTrack> Get()
        {
            OpenConnection();

            OracleCommand command = new OracleCommand("SELECT * FROM TRM_ATTACHEDTRACK", Connection);
            List<AttachedTrack> attachedTracks = new List<AttachedTrack>();

            try
            {
                OracleDataReader reader = command.ExecuteReader();

                UnitOfWork uow = new UnitOfWork();

                while (reader.Read())
                {
                    Track a = uow.Tracks.Where(x => x.ID == Convert.ToInt32(reader["TRACK_ID"])).First();
                    Track b = uow.Tracks.Where(x => x.ID == Convert.ToInt32(reader["NEXTTRACK_ID"])).First();

                    AttachedTrack next = new AttachedTrack(0, a, b);

                    attachedTracks.Add(next);
                }
            }
            catch (System.InvalidOperationException e)
            {
                Console.WriteLine("A connection could not be made.");
            }
            

            CloseConnection();

            return attachedTracks;
        }

    }
}

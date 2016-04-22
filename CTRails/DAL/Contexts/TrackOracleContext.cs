using System;
using System.Collections.Generic;
using System.Linq;
using CTRails.Entities;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class TrackOracleContext : OracleDatabaseContext, IDataContext<Track>
    {

        public TrackOracleContext()
            : base()
        {
            
        }

        public void Add(Track entity)
        {
            OpenConnection();

            string query = @"INSERT INTO TRM_TRACK VALUES(NULL)";

            ExecuteQuery(query, null);

            CloseConnection();
        }



        public void Delete(Track entity)
        {
            OpenConnection();

            string query = @"DELETE FROM TRM_TRACK WHERE ID = :id";

            OracleParameter[] parameters = {
                new OracleParameter(":id", entity.ID)
            };

            ExecuteQuery(query, parameters);

            CloseConnection();
        }



        public void Update(Track entity)
        {
            throw new InvalidOperationException("Track is a single row auto increment table and cannot be updated.");
        }


        public IEnumerable<Track> Get()
        {
            OpenConnection();

            string query = @"SELECT ID FROM TRM_TRACK";

            OracleDataReader reader = ResultSet(query, null);

            List<Track> tracks = new List<Track>();

            while (reader.Read())
                tracks.Add(new Track(Convert.ToInt32(reader["ID"])));


            foreach (Track t in tracks)
            {
                string queryTrackRoutes = @"SELECT ID, NAME FROM TRM_ROUTE r INNER JOIN TRM_TRACK_ROUTE tr ON tr.TRACK_ID = r.ID WHERE tr.TRACK_ID = :track_id";
                string queryAttachedTracks = @"SELECT NEXTTRACK_ID FROM TRM_ATTACHEDTRACK at WHERE at.TRACK_ID = :track_id";

                // Find and add any routes available for this track.
                reader = ResultSet(queryTrackRoutes, new[] {
                    new OracleParameter("track_id", t.ID)
                });
                while (reader.Read())
                    t.Routes.Add(new Route(Convert.ToInt32(reader["ID"]), reader["NAME"].ToString()));

                // Find and add any tracks attached to this track.
                reader = ResultSet(queryAttachedTracks, new[] {
                    new OracleParameter("track_id", t.ID)
                });
                while (reader.Read())
                    t.Attached.Add(tracks.First(x => x.ID == Convert.ToInt32(reader["NEXTTRACK_ID"])));

            }

            CloseConnection();

            return tracks;
        }

    }
}

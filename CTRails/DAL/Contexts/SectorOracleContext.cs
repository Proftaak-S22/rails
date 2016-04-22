using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using Oracle.ManagedDataAccess.Client;
using CTRails.Entities;

namespace CTRails.DAL.Contexts
{
    class SectorOracleContext : OracleDatabaseContext, IDataContext<Sector>
    {
        public SectorOracleContext()
            : base()
        {

        }

        public void Add(Sector sector)
        {
            OpenConnection();

            string query = @"INSERT INTO TRM_SECTION (ID, TRACK_ID, TRAM_ID) VALUES(:id, :track_id, :tram_id)";
            
            OracleCommand command = new OracleCommand(query, Connection);

            OracleParameter[] parameters = {
                    new OracleParameter("id", sector.ID),
                    new OracleParameter("track_id", sector.TrackID)
            };

            command.Parameters.AddRange(parameters);

            if (sector.TramID == -1)
                command.Parameters.Add(new OracleParameter("tram_id", DBNull.Value));
            else
                command.Parameters.Add(new OracleParameter("tram_id", sector.TramID));

            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void Delete(Sector sector)
        {
            OpenConnection();

            string query = @"DELETE FROM TRM_SECTION WHERE ID = :id";

            OracleCommand command = new OracleCommand(query, Connection);

            OracleParameter[] parameters = {
                    new OracleParameter("id", sector.ID)
            };

            command.ExecuteNonQuery();

            CloseConnection();
        }

        public IEnumerable<Sector> Get()
        {
            OpenConnection();

            string selectSectors = @"SELECT ID, TRACK_ID, TRAM_ID FROM TRM_SECTION";

            OracleCommand command = new OracleCommand(selectSectors, Connection);

            OracleDataReader reader = command.ExecuteReader();

            List<Sector> sectors = new List<Sector>();

            // Load in sectors.
            while (reader.Read())
            {
                int id = (reader["ID"] == DBNull.Value) ? -1 : Convert.ToInt32(reader["ID"]);
                int track_id = (reader["TRACK_ID"] == DBNull.Value) ? -1 : Convert.ToInt32(reader["TRACK_ID"]);
                int tram_id = (reader["TRAM_ID"] == DBNull.Value) ? -1 : Convert.ToInt32(reader["TRAM_ID"]);

                sectors.Add(new Sector(id, track_id, tram_id));
            }


            // For every sector, find the tram that occupies it.
            foreach (Sector s in sectors)
            {
                string selectSectorTram = @"SELECT ID, TRAMCODE FROM TRM_TRAM WHERE ID = :tram_id";

                OracleParameter[] parameters = {
                    new OracleParameter("tram_id", s.TramID)
                };

                command = new OracleCommand(selectSectorTram, Connection);

                command.Parameters.AddRange(parameters);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = (reader["ID"] == DBNull.Value) ? -1 : Convert.ToInt32(reader["ID"]);
                    int tramcode = (reader["TRAMCODE"] == DBNull.Value) ? -1 : Convert.ToInt32(reader["TRAMCODE"]);

                    s.Tram = new Tram(id, tramcode);
                }
            }

            CloseConnection();

            return sectors;
        }

        public void Update(Sector sector)
        {
            OpenConnection();

            string query = @"UPDATE TRM_SECTION SET TRACK_ID = :track_id, TRAM_ID = :tram_id WHERE ID = :id";

            OracleParameter[] parameters = {
                 new OracleParameter("id",sector.ID),
                 new OracleParameter("track_id",sector.TrackID),
                 new OracleParameter("tram_id", sector.TramID)
            };

            OracleCommand command = new OracleCommand(query, Connection);

            command.Parameters.AddRange(parameters);

            command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}

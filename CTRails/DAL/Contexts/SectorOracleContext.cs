using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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

            string values = "(1, " + sector.SectionNumber + ", ";
            values += sector.TrackNumber + ")";

            OracleCommand cmd = new OracleCommand("INSERT INTO TRM_SECTION (ID, TRACK_ID) VALUES" + values, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public void Delete(Sector sector)
        {
            OpenConnection();

            OracleCommand cmd = new OracleCommand("DELETE FROM TRM_SECTION WHERE ID = " + sector.SectionNumber, Connection);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public IEnumerable<Sector> Get()
        {
            OpenConnection();

            OracleCommand command = new OracleCommand("SELECT * FROM TRM_SECTION", Connection);

            OracleDataReader reader = command.ExecuteReader();

            List<Sector> sectors = new List<Sector>();

            while (reader.Read())
            {
                Sector next = new Sector(
                        Convert.ToInt32(reader["ID"]),
                        Convert.ToInt32(reader["TRACK_ID"]));

                sectors.Add(next);
            }

            CloseConnection();

            return sectors;
        }

        public void Update(Sector sector)
        {
            
        }
    }
}

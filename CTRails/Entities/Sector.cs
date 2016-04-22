using System.Collections.Generic;
using CTRails.DAL;


namespace CTRails.Entities
{
    public class Sector : Entity
    {
        //Fields
        public int Number { get; set; }



        /// <summary>
        /// The encompassing track that holds the sector.
        /// </summary>
        public int TrackID { get; set; }


        /// <summary>
        /// The tram id that's currently occupying this sector. or -1.
        /// </summary>
        public int TramID
        {
            get; set;
        }

        public Tram Tram { get; set; }

        /// <summary>
        /// Creates a sector object.
        /// </summary>
        /// <param name="id"> Specifies the sector ID number. </param>
        /// <param name="trackID"> Specifies the track ID to which this sector belongs. </param>
        /// <param name="tramID"> Specifies the occupying tram id, or -1 if not occupied.  </param>
        public Sector(int id, int trackID, int tramID = -1)
            : base(id)
        {
            TrackID = trackID;
            TramID = tramID;
        }
    }
}

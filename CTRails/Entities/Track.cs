using CTRails.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CTRails.Entities.Employees;


namespace CTRails.Entities
{
    /// <summary>
    /// Represents a track for tram transportation.
    /// </summary>
    public class Track : Entity
    {

        /// <summary>
        /// A list of routes available for this track.
        /// </summary>
        public List<Route> Routes { get; set; } = new List<Route>(); 



        /// <summary>
        /// A list of tracks attached to this one.
        /// </summary>
        public List<Track> Attached { get; set; } = new List<Track>();



        /// <summary>
        /// The list of sectors that make up this track.
        /// </summary>
        public List<Sector> Sectors { get; set; } = new List<Sector>(); 



        /// <summary>
        /// Creates a new track instance.
        /// </summary>
        /// <param name="id"> Specifies the unique intentifier for this track. </param>
        public Track(int id) : base(id) { }
    }
}


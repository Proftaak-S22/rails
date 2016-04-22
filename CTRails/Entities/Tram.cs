using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails
{
    /// <summary>
    /// Represents a tram entity.
    /// </summary>
    public class Tram : Entity
    {
        /// <summary>
        /// The tram's unique code.
        /// </summary>
        public int Code { get; private set; }



        /// <summary>
        /// The tram's status list.
        /// </summary>
        public List<Status> Statuses { get; set; } = new List<Status>();



        /// <summary>
        /// The trams designated route.
        /// </summary>
        public Route Route { get; set; }



        /// <summary>
        /// The trams current driver.
        /// TODO: SET
        /// </summary>
        public Driver Driver { get; set; }


        /// <summary>
        /// Creates a tram instance.
        /// </summary>
        /// <param name="id"> Specifies a unique identifier. </param>
        /// <param name="code"> Specifies a unique tram code. </param>
        public Tram(int id, int code) : base(id)
        {
            Code = code;
        }
    }
}

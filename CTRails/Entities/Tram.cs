using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails
{
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
        /// The tram's current route, if any.
        /// </summary>
        public Route Route { get; set; }

        /// <summary>
        /// The tram's current driver, if any.
        /// </summary>
        public Driver Driver { get; set; }


        // TODO: REMOVE
        public Tram(int id, int code, Status status) : base(id)
        {
            Code = code;
        }

        public Tram(int id, int code) : base(id)
        {
            Code = code;
        }
    }
}

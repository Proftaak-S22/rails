using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Entities
{
    class TramStatus : Entity
    {
        //Fields
        public Tram tram { get; set; }

        public Status status { get; set; }


        //Constructor
        public TramStatus(int id, Tram tram, Status status) : base(id)
        {
            this.tram = tram;
            this.status = status;
        }
    }
}

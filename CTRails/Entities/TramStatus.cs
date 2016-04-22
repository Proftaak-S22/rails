using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Entities
{
    public class TramStatus : Entity
    {
        //Fields
        public Tram Tram { get; set; }

        public Status Status { get; set; }


        //Constructor
        public TramStatus(Tram tram, Status status) 
            : base()
        {
            Tram = tram;
            Status = status;
        }
    }
}

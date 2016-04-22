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
        public int TramID { get; set; }

        public int StatusID { get; set; }


        //Constructor
        public TramStatus(int tramId, int statusId) 
            : base()
        {
            TramID = tramId;
            StatusID = statusId;
        }
    }
}

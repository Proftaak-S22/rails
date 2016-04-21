using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTRails.Entities;


namespace CTRails
{
    public class Tram : Entity
    {
        //Fields
        public int Code { get; private set; }

        public Status Status { get; set; }


        //Constructor
        public Tram(int id, int code, Status status) : base(id)
        {
            Code = code;
            Status = status;
        }

        public Tram(int id, int code) : base(id)
        {
            Code = code;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Entities
{
    public class Route : Entity
    {
        //Fields
        public string Name { get; set; }

        //Constructor
        public Route(int id, string name) : base(id)
        {
            Name = name;
        }
    }
}

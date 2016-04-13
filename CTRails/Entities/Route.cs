using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Entities
{
    class Route
    {
        public string Name { get; set; }
        public Route (int id, string name)
        {
            Name = name;
        }
    }
}

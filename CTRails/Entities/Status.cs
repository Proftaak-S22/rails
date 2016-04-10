using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Entities
{
    public class Status : Entity
    {
        public string Name { get; private set; }

        public Status(int id, string name) : base(id)
        {
            Name = name;
        }

    }
}

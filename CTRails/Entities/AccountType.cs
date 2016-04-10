using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Entities
{
    public class AccountType : Entity
    {
        public string Name { get; private set; }



        public AccountType(int id, string name) : base(id)
        {
            Name = name;
        }

    }
}

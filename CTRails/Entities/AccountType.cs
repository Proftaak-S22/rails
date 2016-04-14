using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Entities
{
    public class AccountType : Entity
    {
        //Fields
        public string Name { get; private set; }

        //Contructor
        public AccountType(
            int id, 
            string name
            ) 
            : base(id)
        {
            Name = name;
        }

    }
}

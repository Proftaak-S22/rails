using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CTRails.DAL.Contexts;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails.DAL
{
    public abstract class TestDatabaseContext<T>
    {


        public List<T> Entities { get; protected set; } = new List<T>();

    }
}

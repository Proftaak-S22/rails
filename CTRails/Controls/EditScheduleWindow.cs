using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTRails.Entities.Employees;


namespace CTRails.Controls
{
    public partial class EditScheduleWindow : UserControl
    {
        public Type AccountType { get; private set; }

        public EditScheduleWindow()
        {
            InitializeComponent();
        }



        public bool Initialize(Employee accountType)
        {
            if (accountType.GetType() == typeof (Janitor) || accountType.GetType() == typeof(Technician))
            {
                AccountType = accountType.GetType();
                return true;
            }

            return false;
        }
    }
}

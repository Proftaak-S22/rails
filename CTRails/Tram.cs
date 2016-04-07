using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails
{
    public class Tram
    {
        //Fields
        private int tramNumber;
        private Status status;

        //Constructor
        public Tram(int tramNumber, Status status)
        {
            this.tramNumber = tramNumber;
            this.status = status;
        }

        //Methods
        public void RemoveTram(Tram tram)
        {
            
        }

        public void EditTram(Tram tram)
        {
            
        }
    }
}
public enum Status { }

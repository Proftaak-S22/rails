using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails
{
    public class Tram
    {
        private int tramNumber;
        private Status status;
        public Tram (int tramNumber, Status status) { }
        
        public void RemoveTram(Tram tram) { }
        public void EditTram(Tram tram) { }
    }
}
public enum Status { }

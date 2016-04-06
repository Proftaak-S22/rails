using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails
{
    class Track
    {
        private int trackNumber;
        public Track(int trackNumber, Section section)
        {
            this.trackNumber = trackNumber;
        }

        public void RemoveTrack(Track track) { }
    }
}

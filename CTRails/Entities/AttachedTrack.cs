using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Entities
{
    public class AttachedTrack : Entity
    {
        //Fields
        public int TrackID { get; private set; }

        public int NextTrackID { get; private set; }

        //Constructor
        public AttachedTrack(int trackID, int nextTrackID) : base()
        {
            TrackID = trackID;
            NextTrackID = nextTrackID;
        }
    }
}

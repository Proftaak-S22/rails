using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Entities
{
    class AttachedTrack : Entity
    {
        //Fields
        public Track Track { get; private set; }
        public Track Attached { get; private set; }

        //Constructor
        public AttachedTrack( int id, Track track, Track attached) : base(id)
        {
            Track = track;
            Attached = attached;
        }
    }
}

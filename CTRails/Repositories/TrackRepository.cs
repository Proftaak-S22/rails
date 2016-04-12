using System.Collections.Generic;
using System.Linq;
using CTRails.Data;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails.Repositories
{
    public class TrackRepository : Repository<Track>, ITrackRepository
    {

        public IRailsDataContext Context { get; set; }



        public TrackRepository(IRailsDataContext context)
            : base(context)
        {
            Context = context;
        }

    }
}

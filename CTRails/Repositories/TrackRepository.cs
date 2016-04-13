using System.Collections.Generic;
using System.Linq;
using CTRails.Data;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails.Repositories
{
    public class TrackRepository : RailsRepository<Track>, ITrackRepository
    {
        public TrackRepository(IRailsDataContext context)
            : base(context)
        {
            
        }
    }
}

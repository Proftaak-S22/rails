using System.Collections.Generic;
using System.Linq;
using CTRails.Data;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails.Repositories
{
    public class TrackRepository : Repository<Track>, IRepository<Track>
    {

        public TrackRepository(IRailsDataContext context)
            : base(context)
        {
            
        }

    }
}

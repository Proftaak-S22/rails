using CTRails.DAL.Contexts;
using CTRails.Entities;


namespace CTRails.DAL.Repositories
{
    public class TrackRepository : Repository<Track>
    {
        public TrackRepository(IDataContext<Track> context)
            : base(context)
        {
            
        }
    }
}

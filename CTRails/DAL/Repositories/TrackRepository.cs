using CTRails.Entities;


namespace CTRails.DAL.Repositories
{
    public class TrackRepository : RailsRepository<Track>, ITrackRepository
    {
        public TrackRepository(IRailsDataContext context)
            : base(context)
        {
            
        }
    }
}

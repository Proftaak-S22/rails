using CTRails.DAL.Contexts;
using CTRails.Entities;


namespace CTRails.DAL.Repositories
{
    public class TrackRepository : Repository<Track>
    {
        public Track AttachedTo { get; set; }

        public TrackRepository(IDataContext<Track> context)
            : base(context)
        {
            
        }
    }
}

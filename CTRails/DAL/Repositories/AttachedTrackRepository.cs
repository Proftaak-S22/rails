using CTRails.DAL.Contexts;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails.DAL.Repositories
{
    public class AttachedTrackRepository : Repository<AttachedTrack>
    {
        public AttachedTrackRepository(IDataContext<AttachedTrack> context)
            : base(context)
        {
            
        }
    }
}

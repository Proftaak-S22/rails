using CTRails.DAL.Contexts;
using CTRails.Entities;


namespace CTRails.DAL.Repositories
{
    public class TramStatusRepository : Repository<TramStatus>
    {
        public TramStatusRepository(IDataContext<TramStatus> context)
            : base(context)
        {
            
        }
    }
}

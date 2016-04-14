using CTRails.DAL.Contexts;
using CTRails.Entities;


namespace CTRails.DAL.Repositories
{
    public class TramRepository : Repository<Tram>
    {
        public TramRepository(IDataContext<Tram> context)
            : base(context)
        {
            
        }
    }
}

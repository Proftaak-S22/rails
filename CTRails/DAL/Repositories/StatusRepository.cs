using CTRails.DAL.Contexts;
using CTRails.Entities;


namespace CTRails.DAL.Repositories
{
    public class StatusRepository : Repository<Status>
    {
        public StatusRepository(IDataContext<Status> context)
            : base(context)
        {

        }
    }
}

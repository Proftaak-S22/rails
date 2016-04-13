using CTRails.Entities;


namespace CTRails.DAL.Repositories
{
    public class StatusRepository : RailsRepository<Status>, IStatusRepository
    {
        public StatusRepository(IRailsDataContext context)
            : base(context)
        {

        }
    }
}

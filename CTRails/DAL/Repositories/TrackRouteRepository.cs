using CTRails.DAL.Contexts;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails.DAL.Repositories
{
    public class TrackRouteRepository : Repository<TrackRoute>
    {
        public TrackRouteRepository(IDataContext<TrackRoute> context)
            : base(context)
        {
            
        }
    }
}

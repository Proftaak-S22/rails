using CTRails.DAL.Contexts;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails.DAL.Repositories
{
    public class TramRouteRepository : Repository<TramRoute>
    {
        public TramRouteRepository(IDataContext<TramRoute> context)
            : base(context)
        {
            
        }
    }
}

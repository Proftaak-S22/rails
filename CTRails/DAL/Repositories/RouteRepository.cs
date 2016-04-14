using CTRails.DAL.Contexts;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails.DAL.Repositories
{
    public class RouteRepository : Repository<Route>
    {
        public RouteRepository(IDataContext<Route> context)
            : base(context)
        {
            
        }
    }
}

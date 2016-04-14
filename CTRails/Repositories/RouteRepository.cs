using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRails.Repositories
{
    class RouteRepository : Repository<Route>, IRouteRepository
    {
        public RouteRepository(IRouteRepository context)
            : base(context)
        {

        }
    }
}

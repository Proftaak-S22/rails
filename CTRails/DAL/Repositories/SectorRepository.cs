using CTRails.DAL.Contexts;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails.DAL.Repositories
{
    public class SectorRepository : Repository<Sector>
    {
        public SectorRepository(IDataContext<Sector> context)
            : base(context)
        {
            
        }
    }
}

using System.Linq;


namespace CTRails.DAL.Repositories
{
    public abstract class RailsRepository<T> : Repository<T> where T : class
    {

        public IRailsDataContext Context { get { return (IRailsDataContext) context; } }

        public RailsRepository(IRailsDataContext context)
            : base(context)
        {
            
        } 

        public override T Get(int id)
        {
            return context.Set<T>().First(x => 
            x.GetType().GetProperty("ID", typeof(int)) != null && 
            (int) x.GetType().GetProperty("ID", typeof(int)).GetValue(x) == id);
        }

    }
}

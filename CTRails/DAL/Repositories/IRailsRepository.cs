namespace CTRails.DAL.Repositories
{
    public interface IRailsRepository<T> : IRepository<T> where T : class
    {
        IRailsDataContext Context { get; }
    }
}

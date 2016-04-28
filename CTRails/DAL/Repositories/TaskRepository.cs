using CTRails.DAL.Contexts;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails.DAL.Repositories
{
    public class TaskRepository : Repository<Task>
    {
        public TaskRepository(IDataContext<Task> context)
            : base(context)
        {
            
        }
    }
}

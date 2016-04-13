using CTRails.Entities.Employees;


namespace CTRails.DAL.Repositories
{
    public class EmployeeRepository : RailsRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IRailsDataContext context)
            : base(context)
        {
            
        }

    }
}

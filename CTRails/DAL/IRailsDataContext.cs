using System.Collections.Generic;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails.DAL
{
    public interface IRailsDataContext : IDataContext
    {
        IEnumerable<Employee> Employees { get; }
        IEnumerable<Status> Statuses { get; }
        IEnumerable<AccountType> AccountTypes { get; }
    }
}

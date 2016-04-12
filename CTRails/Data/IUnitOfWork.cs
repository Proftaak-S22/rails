using System;
using CTRails.Entities.Employees;
using CTRails.Repositories;


namespace CTRails.Data
{
    public interface IUnitOfWork : IDisposable
    {
        Repository<Employee> Employees { get; }
        IStatusRepository Statuses { get; }
        IAccountTypeRepository AccountTypes { get; }
        int Complete();
    }
}

using System;
using CTRails.Repositories;


namespace CTRails.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employees { get; }
        IStatusRepository Statuses { get; }
        IAccountTypeRepository AccountTypes { get; }
        int Complete();
    }
}

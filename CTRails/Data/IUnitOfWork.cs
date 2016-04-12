using System;
using CTRails.Entities.Employees;
using CTRails.Repositories;


namespace CTRails.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employees { get; }
        IStatusRepository Statuses { get; }
        IAccountTypeRepository AccountTypes { get; }
        ITrackRepository Tracks { get; }
        int Complete();
    }
}

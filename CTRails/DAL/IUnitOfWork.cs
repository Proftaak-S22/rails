using System;
using CTRails.DAL.Repositories;


namespace CTRails.DAL
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

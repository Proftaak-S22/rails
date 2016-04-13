using System;
using CTRails.DAL.Repositories;


namespace CTRails.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}

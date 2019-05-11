using System;

namespace SelimLibrary.Data.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IMemberRepository Members { get; }
        int Complete();
    }
}
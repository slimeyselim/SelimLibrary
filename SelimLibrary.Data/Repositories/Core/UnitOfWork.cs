using System;
using System.Collections.Generic;
using System.Text;

namespace SelimLibrary.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SelimLibraryDataContext _selimLibraryDataContext;

        public UnitOfWork(SelimLibraryDataContext selimLibraryDataContext)
        {
            _selimLibraryDataContext = selimLibraryDataContext;
            Members = new MemberRepository(_selimLibraryDataContext);
        }

        public IMemberRepository Members { get; private set; }

        public int Complete()
        {
            return _selimLibraryDataContext.SaveChanges();
        }

        public void Dispose()
        {
            _selimLibraryDataContext.Dispose();
        }
    }
}

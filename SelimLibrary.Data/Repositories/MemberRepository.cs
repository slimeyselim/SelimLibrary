using SelimLibrary.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelimLibrary.Data.Repositories
{
    public class MemberRepository : Repository<Member>, IMemberRepository
    {
        public MemberRepository(SelimLibraryDataContext selimLibraryDataContext)
            :base(selimLibraryDataContext)
        { }

        public SelimLibraryDataContext SelimLibraryDataContext
        {
            get { return _context as SelimLibraryDataContext; }
        }

        public void AddMember(Member member)
        {
            SelimLibraryDataContext.Members.Add(member);
        }
    }
}

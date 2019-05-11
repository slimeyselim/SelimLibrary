using SelimLibrary.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelimLibrary.Data.Repositories
{
    public interface IMemberRepository : IRepository<Member>
    {
        void AddMember(Member member);
    }
}

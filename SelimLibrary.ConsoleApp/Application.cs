using SelimLibrary.ConsoleUI;
using SelimLibrary.Data;
using SelimLibrary.Data.Entities;
using SelimLibrary.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelimLibrary.ConsoleApp
{
    public class Application : IApplication
    {
        IMember _member;
        ICollectData _collectData;

        public Application(IMember member, ICollectData collectData)
        {
            _member = member;
            _collectData = collectData;
        }

        public void Run()
        {
            using (var unitOfWork = new UnitOfWork(new SelimLibraryDataContext()))
            {
                _member = _collectData.MemberInfo();
                
                unitOfWork.Members.AddMember((Member)_member);
                unitOfWork.Complete();
                Console.ReadLine();
            }
        }
    }
}

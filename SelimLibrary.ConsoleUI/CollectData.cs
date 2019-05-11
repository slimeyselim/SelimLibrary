using SelimLibrary.Data.Entities;
using System;

namespace SelimLibrary.ConsoleUI
{
    public class CollectData : ICollectData
    {
        IMember _member;

        public CollectData(IMember member)
        {
            _member = member;
        }

        public IMember MemberInfo()
        {
            Console.Write("Enter your first name:");
            _member.FirstName =  Console.ReadLine();
            Console.Write("Enter your last name:");
            _member.LastName = Console.ReadLine();
            _member.Username = CreateUserName(_member.FirstName, _member.LastName);
            Console.WriteLine($"your username is {_member.Username}");
            _member.Password = "password";
            Console.WriteLine($"your password is {_member.Password}");
            Console.Write("Enter your email:");
            _member.Email = Console.ReadLine();

            return _member;
        }

        private string CreateUserName(string firstname, string lastname)
        {
            return $"{firstname}.{lastname}";
        }
    }
}

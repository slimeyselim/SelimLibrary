using Autofac;
using SelimLibrary.ConsoleUI;
using SelimLibrary.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelimLibrary.ConsoleApp
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<Member>().As<IMember>();
            builder.RegisterType<CollectData>().As<ICollectData>();


            return builder.Build();
        }
    }
}

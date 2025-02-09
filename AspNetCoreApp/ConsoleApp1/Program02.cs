using ConsoleApp1.ServiceImplements;
using ConsoleApp1.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program02
    {
        public void Run()
        {
            Console.WriteLine("ASP NET CORE - ServiceCollection - 2");

            ServiceCollection services = new ServiceCollection();
            services.AddTransient<IDataExporter, JsonDataExporter>();
            services.AddTransient<IDataExporter, HtmlDataExporter>();
            services.AddTransient<DataSender>();

            IServiceProvider provider = services.BuildServiceProvider();
            DataSender? dataSender = provider.GetService<DataSender>();
            if (dataSender == null)
            {
                Console.WriteLine("the service is not exists.");
                return;
            }

            dataSender.Send("Hi! I am Rice.");
        }
    }
}

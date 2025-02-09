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
    internal class Program01
    {
        public void Run()
        {
            Console.WriteLine("ASP NET CORE - ServiceCollection - 1");

            ServiceCollection services = new ServiceCollection();
            services.AddTransient<ITestService, MyServiceA>();

            IServiceProvider provider = services.BuildServiceProvider();
            ITestService? testService = provider.GetService<ITestService>();
            if (testService == null)
            {
                Console.WriteLine("the service is not exists.");
                return;
            }

            string message = testService.GetMessage();
            Console.WriteLine(message);
        }
    }
}

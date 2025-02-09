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
    internal class Program05
    {
        public void Run()
        {
            Console.WriteLine("ASP NET CORE - ServiceCollection - 5");

            ServiceCollection services = new ServiceCollection();
            services.AddTransient<IDataExporter, JsonDataExporter>();
            services.AddTransient<IDataExporter, HtmlDataExporter>();

            IServiceProvider provider = services.BuildServiceProvider();
            IEnumerable<IDataExporter> dataExporters = provider.GetServices<IDataExporter>();

            string content = "this is my content.";
            foreach (var dataExporter in dataExporters)
            {
                string output = dataExporter.Output(content);
                Console.WriteLine(output);
            }
        }
    }
}

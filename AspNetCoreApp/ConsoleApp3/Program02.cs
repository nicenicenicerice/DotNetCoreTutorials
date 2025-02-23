using ConsoleApp3.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program02
    {
        public void Run()
        {
            Console.WriteLine("ASP NET CORE - Options - sample 1");

            ServiceCollection services = new ServiceCollection();

            services.Configure<Test1Options>(opt =>
            {
                opt.ParamA = "Rice";
                opt.ParamB = "Core";
            });

            IServiceProvider provider = services.BuildServiceProvider();
            IOptions<Test1Options>? options = provider.GetService<IOptions<Test1Options>>();
            if (options == null)
            {
                Console.WriteLine("the service is not exists.");
                return;
            }

            Test1Options testOptions = options.Value;
            Console.WriteLine($"TestOptions: ParamA = {testOptions.ParamA} ; ParamB = {testOptions.ParamB}");
        }
    }
}

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
    internal class Program04
    {
        public void Run()
        {
            Console.WriteLine("ASP NET CORE - Options - sample 3");

            ServiceCollection services = new ServiceCollection();

            services.Configure<Test1Options>("group-1", opt =>
            {
                opt.ParamA = "G1-A";
                opt.ParamB = "G1-B";
            });

            services.Configure<Test1Options>("group-2", opt =>
            {
                opt.ParamA = "G2-A";
                opt.ParamB = "G2-B";
            });

            IServiceProvider provider = services.BuildServiceProvider();

            using (IServiceScope scope = provider.CreateScope())
            {
                IOptionsSnapshot<Test1Options>? options = scope.ServiceProvider.GetService<IOptionsSnapshot<Test1Options>>();
                if (options == null)
                {
                    Console.WriteLine("the service is not exists.");
                    return;
                }

                Test1Options testOptions0 = options.Value;
                Console.WriteLine($"testOptions in default group: ParamA = {testOptions0.ParamA} ; ParamB = {testOptions0.ParamB}");

                Test1Options testOptions1 = options.Get("group-1");
                Console.WriteLine($"testOptions in group 1: ParamA = {testOptions1.ParamA} ; ParamB = {testOptions1.ParamB}");

                Test1Options testOptions2 = options.Get("group-2");
                Console.WriteLine($"testOptions in group 2: ParamA = {testOptions2.ParamA} ; ParamB = {testOptions2.ParamB}");
            }
        }
    }
}

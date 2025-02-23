using ConsoleApp3.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program03
    {
        private const string JSON_CONFIG_PATH = "appsettings.json";

        public void Run()
        {
            Console.WriteLine("ASP NET CORE - Options - sample 2");

            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(JSON_CONFIG_PATH, optional: false, reloadOnChange: true)
                .Build();

            ServiceCollection services = new ServiceCollection();

            services.Configure<Test2Options>(config.GetSection("Test2Options"));

            IServiceProvider provider = services.BuildServiceProvider();
            IOptionsMonitor<Test2Options>? options = provider.GetService<IOptionsMonitor<Test2Options>>();
            if (options == null)
            {
                Console.WriteLine("the service is not exists.");
                return;
            }

            Test2Options testOptions = options.CurrentValue;
            Console.WriteLine($"TestOptions: ParamCd = {testOptions.ParamCd} ; ParamEf = {testOptions.ParamEf}");
        }
    }
}

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
    internal class Program08
    {
        public void Run()
        {
            Console.WriteLine("ASP NET CORE - Options - sample 7");

            ServiceCollection services = new ServiceCollection();

            services.AddOptions<Test3Options>()
                .Configure(opt =>
                {
                    opt.Id = 1;
                    opt.Num = 100;
                    opt.Description = "1234567890ABC";
                })
                .ValidateDataAnnotations()
                .ValidateOnStart();

            IServiceProvider provider = services.BuildServiceProvider();
            IOptions<Test3Options>? options = provider.GetService<IOptions<Test3Options>>();
            if (options == null)
            {
                Console.WriteLine("the service is not exists.");
                return;
            }

            try
            {
                Test3Options testOptions = options.Value; // <--
                Console.WriteLine($"TestOptions: Id = {testOptions.Id} ; Num = {testOptions.Num} ; Description = {testOptions.Description}");
            }
            catch (OptionsValidationException ex)
            {
                Console.WriteLine($"An options validator exception occurred:{ex.Message}");
            }
        }
    }
}

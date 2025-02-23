using ConsoleApp3.Options;
using ConsoleApp3.OptionsValidators;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program06
    {
        public void Run()
        {
            Console.WriteLine("ASP NET CORE - Options - sample 5");

            ServiceCollection services = new ServiceCollection();

            services.AddOptions<Test1Options>()
                .Configure(opt =>
                {
                    opt.ParamA = "Rice";
                    opt.ParamB = "Core";
                })
                .Services.AddSingleton<IValidateOptions<Test1Options>, Test1OptionsValidator>();

            IServiceProvider provider = services.BuildServiceProvider();
            IOptions<Test1Options>? options = provider.GetService<IOptions<Test1Options>>();
            if (options == null)
            {
                Console.WriteLine("the service is not exists.");
                return;
            }

            try
            {
                Test1Options testOptions = options.Value; // <--
                Console.WriteLine($"TestOptions: ParamA = {testOptions.ParamA} ; ParamB = {testOptions.ParamB}");
            }
            catch (OptionsValidationException ex)
            {
                Console.WriteLine($"An options validator exception occurred:{ex.Message}");
            }
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program06
    {
        public void Run()
        {
            Console.WriteLine("ASP NET CORE - Configuration - Environment Variables");

            Console.WriteLine("General Environment Variables:");
            UseGeneralEnvironmentVariables();
            Console.WriteLine("------------------------------");

            Console.WriteLine("Custom Prefix Environment Variables:");
            UseCustomPrefixEnvironmentVariables();
            Console.WriteLine("------------------------------");

            Console.WriteLine("Hierarchical Environment Variables:");
            UseHierarchicalEnvironmentVariables();
            Console.WriteLine("------------------------------");
        }

        private void UseGeneralEnvironmentVariables()
        {
            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.AddEnvironmentVariables();

            IConfiguration config = configBuilder.Build();

            ConfigurationRoot configRoot = (ConfigurationRoot)config;
            var envProviders = configRoot.Providers.Where(p => p is EnvironmentVariablesConfigurationProvider);

            foreach (var provider in envProviders)
            {
                foreach (string? key in provider.GetChildKeys(Enumerable.Empty<string>(), null))
                {
                    if (provider.TryGet(key, out string? val))
                    {
                        Console.WriteLine($"{key} = {val}");
                    }
                }
            }
        }

        private void UseCustomPrefixEnvironmentVariables()
        {
            /*
             CMD: set APP_INFO=IamRice
             */

            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.AddEnvironmentVariables("APP_");

            IConfiguration config = configBuilder.Build();

            string val = "";

            val = config["INFO"];
            Console.WriteLine($"value of APP_INFO Key = {val}");
        }

        private void UseHierarchicalEnvironmentVariables()
        {
            /*
             CMD: set APP_INFO=IamRice
             CMD: set APP_A__B=ABVal
             CMD: set APP_C__D__E=CDEVal
             */

            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.AddEnvironmentVariables("APP_");

            IConfiguration config = configBuilder.Build();

            string val = "";

            val = config["INFO"];
            Console.WriteLine($"value of APP_INFO Key = {val}");

            val = config["A:B"];
            Console.WriteLine($"value of APP_A__B Key = {val}");

            val = config["C:D:E"];
            Console.WriteLine($"value of APP_C__D__E Key = {val}");
        }
    }
}

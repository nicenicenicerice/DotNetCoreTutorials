using ConsoleApp2.ConfigurationExtensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program03
    {
        private const string CSV_CONFIG_PATH = "Files/cust.csv";

        public void Run()
        {
            Console.WriteLine("ASP NET CORE - Configuration - IConfigurationSource and IConfigurationProvider");

            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.AddCsvFile(CSV_CONFIG_PATH);

            IConfiguration config = configBuilder.Build();

            string val = "";

            val = config["AKey"];
            Console.WriteLine($"value of AKey = {val}");

            ConfigurationRoot configRoot = (ConfigurationRoot)config;
            Console.WriteLine(configRoot.GetDebugView());
        }
    }
}

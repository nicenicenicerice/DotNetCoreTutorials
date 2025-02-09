using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program01
    {
        private const string JSON_CONFIG_PATH = "Files/test.json";

        public void Run()
        {
            Console.WriteLine("ASP NET CORE - Configuration - IConfiguration and IConfigurationBuilder");

            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.AddJsonFile(JSON_CONFIG_PATH);

            IConfiguration config = configBuilder.Build();

            string val = "";

            val = config["AKey"];
            Console.WriteLine($"value of AKey = {val}");

            val = config["BSec:B1Key"];
            Console.WriteLine($"value of BSec:B1Key = {val}");

            ConfigurationRoot configRoot = (ConfigurationRoot)config;
            Console.WriteLine(configRoot.GetDebugView());
        }
    }
}

using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program09
    {
        private const string JSON_CONFIG_PATH = "Files/test.json";
        private const string XML_CONFIG_PATH = "Files/test.xml";

        public void Run(string[] args)
        {
            Console.WriteLine("ASP NET CORE - Configuration - Configuration tree");

            IConfiguration config1 = GetConfig1();
            IConfiguration config2 = GetConfig2();

            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.AddConfiguration(config1);
            configBuilder.AddConfiguration(config2);

            IConfiguration config = configBuilder.Build();

            string val = "";

            val = config["AKey"];
            Console.WriteLine($"value of Json AKey Key = {val}");

            val = config["myapp:A"];
            Console.WriteLine($"value of XML  A    Key = {val}");
        }

        private IConfiguration GetConfig1()
        {
            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.AddJsonFile(JSON_CONFIG_PATH);

            IConfiguration config = configBuilder.Build();
            return config;
        }

        private IConfiguration GetConfig2()
        {
            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.AddXmlFile(XML_CONFIG_PATH);

            IConfiguration config = configBuilder.Build();
            return config;
        }
    }
}

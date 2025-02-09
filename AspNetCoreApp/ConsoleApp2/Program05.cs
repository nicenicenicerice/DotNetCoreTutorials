using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program05
    {
        private const string XML_CONFIG_PATH = "Files/test.xml";

        public void Run()
        {
            Console.WriteLine("ASP NET CORE - Configuration - XML");

            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.AddXmlFile(XML_CONFIG_PATH);

            IConfiguration config = configBuilder.Build();

            string val = "";

            val = config["myapp:A"];
            Console.WriteLine($"value of A Key = {val}");

            val = config["myapp:B:B1"];
            Console.WriteLine($"value of B:B1 Key = {val}");

            val = config["myapp:C"];
            Console.WriteLine($"value of C Key = {val}");

            val = config["myapp:C:C1"];
            Console.WriteLine($"value of C:C1 Key = {val}");

            val = config["myapp:D:D1"];
            Console.WriteLine($"value of D:D1 Key = {val}");

            val = config["myapp:D:Item:0:D3"];
            Console.WriteLine($"value of D:Item:0:D3 Key = {val}");

            ConfigurationRoot configRoot = (ConfigurationRoot)config;
            Console.WriteLine(configRoot.GetDebugView());
        }
    }
}

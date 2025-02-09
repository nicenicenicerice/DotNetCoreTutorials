using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program08
    {
        private const string INI_CONFIG_PATH = "Files/test.ini";

        public void Run(string[] args)
        {
            Console.WriteLine("ASP NET CORE - Configuration - INI");

            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.AddIniFile(INI_CONFIG_PATH);

            IConfiguration config = configBuilder.Build();

            string val = "";

            val = config["myapp:AKey"];
            Console.WriteLine($"value of myapp:AKey Key = {val}");

            var sect = config.GetSection("myapp");
            val = sect["BKey"];
            Console.WriteLine($"value of myapp:BKey Key = {val}");
        }
    }
}

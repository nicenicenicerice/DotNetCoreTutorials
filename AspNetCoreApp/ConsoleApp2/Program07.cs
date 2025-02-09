using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program07
    {
        public void Run(string[] args)
        {
            /*
             CMD: --INFO=IamRice
             CMD: --A:B=ABVal
             CMD: --C:D:E=CDEVal
             */

            Console.WriteLine("ASP NET CORE - Configuration - CMD parameters");

            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.AddCommandLine(args);

            IConfiguration config = configBuilder.Build();

            string val = "";

            val = config["INFO"];
            Console.WriteLine($"value of INFO Key = {val}");

            val = config["A:B"];
            Console.WriteLine($"value of A:B Key = {val}");

            val = config["C:D:E"];
            Console.WriteLine($"value of C:D:E Key = {val}");
        }
    }
}

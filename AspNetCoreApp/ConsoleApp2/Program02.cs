using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program02
    {
        private const string JSON_CONFIG_PATH = "Files/test.json";

        public void Run()
        {
            Console.WriteLine("ASP NET CORE - Configuration - ConfigurationManager");

            ConfigurationManager configMgr = new ConfigurationManager();
            configMgr.AddJsonFile(JSON_CONFIG_PATH);

            string val = "";

            val = configMgr["AKey"];
            Console.WriteLine($"value of AKey = {val}");

            val = configMgr["BSec:B1Key"];
            Console.WriteLine($"value of BSec:B1Key = {val}");

            Console.WriteLine(configMgr.GetDebugView());
        }
    }
}

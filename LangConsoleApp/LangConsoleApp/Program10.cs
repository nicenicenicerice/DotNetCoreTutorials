using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program10
    {
        public static void Run()
        {
            Console.WriteLine("C# - Data Types - Dynamic Types");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-data-types");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-dynamic-type");
            Console.WriteLine("----------------------------------------");

            dynamic d01 = 1;
            PrintInfo("d01", d01);

            d01 = "Hi! I am Rice.";
            PrintInfo("d01", d01);
        }

        private static void PrintInfo(string name, Object obj)
        {
            Console.WriteLine($"{name}: Value = {obj}；Type = {obj.GetType()}");
        }
    }
}

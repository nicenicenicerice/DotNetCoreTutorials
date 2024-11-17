using LangConsoleApp.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program15
    {
        public static void Run()
        {
            Console.WriteLine("C# - Partial Classes and Methods");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-partial-class");
            Console.WriteLine("----------------------------------------");

            Engine engine = new Engine("29534ced-e5ae-467e-9fa6-91e6550c52be", "RiceSuperEngine");
            string engineInfo = engine.GetDescription("This is a partial class sample.");
            Console.WriteLine(engineInfo);
        }
    }
}

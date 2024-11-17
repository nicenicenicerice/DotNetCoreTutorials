using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Tools
{
    internal class Counter
    {
        public static int Total = 0;

        public string Name { get; set; } = "undefined";

        static Counter()
        {
            Console.WriteLine($"Counter static constructor initializing ... : Total = {Total}");
        }

        public Counter(string name)
        {
            Name = name;
            Console.WriteLine($"Counter instance constructor initializing ... : Total = {Total}；Name = {Name}");
        }

        public static void PlusOne()
        {
            Total++;
        }

        public static void DisplayCounterTotal()
        {
            Console.WriteLine($"Counter Total = {Total}");
        }
    }
}

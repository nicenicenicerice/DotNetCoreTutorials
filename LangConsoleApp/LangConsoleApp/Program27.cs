using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program27
    {
        public static void Run()
        {
            Console.WriteLine("C# - Tuple");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-tuple");
            Console.WriteLine("----------------------------------------");

            Tuple<int, string, string> tuple01 = new Tuple<int, string, string>(1, "A", "A-info");

            Tuple<int, string, string> tuple02 = Tuple.Create(2, "B", "B-info");

            var tuple03 = Tuple.Create(3, "C", "C-info");

            var tuple04 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine("tuple04:");
            Console.WriteLine($"tuple04-1 = {tuple04.Item1}");
            Console.WriteLine($"tuple04-2 = {tuple04.Item2}");
            Console.WriteLine($"tuple04-3 = {tuple04.Item3}");
            Console.WriteLine($"tuple04-4 = {tuple04.Item4}");
            Console.WriteLine($"tuple04-5 = {tuple04.Item5}");
            Console.WriteLine($"tuple04-6 = {tuple04.Item6}");
            Console.WriteLine($"tuple04-7 = {tuple04.Item7}");
            Console.WriteLine($"tuple04-8 = {tuple04.Rest.Item1}");

            var tuple05 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9));
            Console.WriteLine("tuple05:");
            Console.WriteLine($"tuple05-1 = {tuple05.Item1}");
            Console.WriteLine($"tuple05-7 = {tuple05.Item7}");
            Console.WriteLine($"tuple05-8 = {tuple05.Rest.Item1.Item1}");
            Console.WriteLine($"tuple05-9 = {tuple05.Rest.Item1.Item2}");

            var tuple06 = Tuple.Create("ABC", "DEF");
            /* Compiler error CS0200
            tuple06.Item1 = "ABC_updated";
            */
            PringInfo("tuple06", tuple06);

            var tuple07 = GenerateTuple();
            PringInfo("tuple07", tuple07);
        }

        static void PringInfo(string name, Tuple<string, string> tuple)
        {
            Console.WriteLine($"{name}: Item1 = {tuple.Item1}；Item2 = {tuple.Item2}");
        }

        static Tuple<string, string> GenerateTuple()
        {
            return Tuple.Create("Rice", "Cool");
        }
    }
}

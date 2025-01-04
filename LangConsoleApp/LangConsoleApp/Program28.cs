using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LangConsoleApp
{
    internal class Program28
    {
        public static void Run()
        {
            Console.WriteLine("C# - ValueTuple");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/valuetuple");
            Console.WriteLine("----------------------------------------");

            ValueTuple<int, int, int> tuple01 = (1, 2, 3);

            (int, int, int) tuple02 = (4, 5, 6);
            Console.WriteLine("tuple02:");
            Console.WriteLine($"Item1 = {tuple02.Item1}");
            Console.WriteLine($"Item2 = {tuple02.Item2}");
            Console.WriteLine($"Item3 = {tuple02.Item3}");

            (int Id, string Name, string Personality) tuple03 = (1, "Rice", "Peaceful");
            Console.WriteLine("tuple03:");
            Console.WriteLine($"Item1       = {tuple03.Item1}");
            Console.WriteLine($"Item2       = {tuple03.Item2}");
            Console.WriteLine($"Item3       = {tuple03.Item3}");
            Console.WriteLine($"Id          = {tuple03.Id}");
            Console.WriteLine($"Name        = {tuple03.Name}");
            Console.WriteLine($"Personality = {tuple03.Personality}");
            Console.WriteLine("----------------------------------------");

            var tuple04 = (7, 8);
            Console.WriteLine($"tuple04 type is {tuple04.GetType()}");

            var justInt = (9);
            Console.WriteLine($"justInt type is {justInt.GetType()} (not ValueTuple)");
            Console.WriteLine("----------------------------------------");

            (int, string) tuple05 = (1, "Rice");
            PrintInfo1("tuple05", tuple05);
            PrintInfo2("tuple05", tuple05);
            Console.WriteLine("----------------------------------------");

            (int, string) tuple06 = GenerateTuple1();
            Console.WriteLine("tuple06:");
            Console.WriteLine($"Item1 = {tuple06.Item1}");
            Console.WriteLine($"Item2 = {tuple06.Item2}");

            (int StudentId, string StudentName) tuple07 = GenerateTuple1();
            Console.WriteLine("tuple07:");
            Console.WriteLine($"StudentId   = {tuple07.StudentId}");
            Console.WriteLine($"StudentName = {tuple07.StudentName}");
            Console.WriteLine("----------------------------------------");

            (int, string) tuple08 = GenerateTuple2();
            Console.WriteLine("tuple08:");
            Console.WriteLine($"Item1 = {tuple08.Item1}");
            Console.WriteLine($"Item2 = {tuple08.Item2}");
            /* Compiler Error CS1061
            Console.WriteLine($"Id    = {tuple08.Id}");
            Console.WriteLine($"Name  = {tuple08.Name}");
            */

            (int StudentId, string StudentName) tuple09 = GenerateTuple2();
            Console.WriteLine("tuple09:");
            Console.WriteLine($"StudentId   = {tuple09.StudentId}");
            Console.WriteLine($"StudentName = {tuple09.StudentName}");

            var tuple10 = GenerateTuple2();
            Console.WriteLine("tuple10:");
            Console.WriteLine($"Id   = {tuple10.Id}");
            Console.WriteLine($"Name = {tuple10.Name}");
        }

        private static void PrintInfo1(string name, (int, string) tuple)
        {
            Console.WriteLine($"{name}:");
            Console.WriteLine($"Item1 = {tuple.Item1}");
            Console.WriteLine($"Item2 = {tuple.Item2}");
        }

        private static void PrintInfo2(string name, (int Id, string Name) tuple)
        {
            Console.WriteLine($"{name}:");
            Console.WriteLine($"Id   = {tuple.Id}");
            Console.WriteLine($"Name = {tuple.Name}");
        }

        private static (int, string) GenerateTuple1()
        {
            return (2, "Sam");
        }

        private static (int Id, string Name) GenerateTuple2()
        {
            return (3, "Emma");
        }
    }
}

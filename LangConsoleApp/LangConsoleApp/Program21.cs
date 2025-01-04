using LangConsoleApp.Configs;
using LangConsoleApp.Graphs;
using LangConsoleApp.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program21
    {
        public static void Run()
        {
            Console.WriteLine("C# Generics and Generic Constraints");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-generics");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/constraints-in-generic-csharp");
            Console.WriteLine("----------------------------------------");

            KeyValuePair<int, string, string> pair01 = new KeyValuePair<int, string, string>();
            pair01.Key = 1;
            pair01.Val = "One";
            pair01.List[0] = "Hello";
            pair01.SetPair(2, "Two");
            string pair01Val = pair01.GetVal();
            Console.WriteLine($"pair01: Key = {pair01.Key}；Type is {pair01.Key.GetType()}");
            Console.WriteLine($"pair01: Val = {pair01.Val}；Type is {pair01.Val.GetType()}");

            KeyValuePair<string, Student, Coordinate3d> pair02 = new KeyValuePair<string, Student, Coordinate3d>();
            pair02.Key = "10803";
            pair02.Val = new Student() { Id = 3, Name = "Rice", SeatNo = 6 };
            pair02.List[0] = new Coordinate3d(10, 20, 30);
            pair02.SetPair("10806", new Student() { Id = 6, Name = "Sam", SeatNo = 9 });
            Student pair02Val = pair02.GetVal();
            Console.WriteLine($"pair02: Key = {pair02.Key}；Type is {pair02.Key.GetType()}");
            Console.WriteLine($"pair02: Val = {pair02.Val}；Type is {pair02.Val.GetType()}");
            Console.WriteLine("----------------------------------------");

            ReferenceKeyValuePair<int, string> pair03 = new ReferenceKeyValuePair<int, string>();

            /* Compiler Error CS0452
            ReferenceKeyValuePair<int, int> pair04 = new ReferenceKeyValuePair<int, int>();
            */

            StructKeyValuePair<int, int> pair05 = new StructKeyValuePair<int, int>();

            /* Compiler Error CS0453
            StructKeyValuePair<int, Student> pair06 = new StructKeyValuePair<int, Student>();
            */
        }
    }
}

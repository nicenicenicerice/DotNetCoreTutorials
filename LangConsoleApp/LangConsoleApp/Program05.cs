using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program05
    {
        public static void Run()
        {
            Console.WriteLine("C# - Data Types - Strings");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-data-types");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-string");
            Console.WriteLine("----------------------------------------");

            string s01 = "hello";
            String s02 = "hello";
            char[] c01 = { 'h', 'e', 'l', 'l', 'o' };
            string s03 = new string(c01);
            string s04 = "A" + "B" + "C";

            for (int i = 0; i < s01.Length; i++)
            {
                Console.Write(s01[i]);
                Console.Write((i == (s01.Length - 1)) ? "\n" : "-");
            }

            int s03Idx = 0;
            foreach (char c in s03)
            {
                Console.Write(c);
                Console.Write((s03Idx == (s03.Length - 1)) ? "\n" : "-");
                s03Idx++;
            }

            string s05 = @"
                Hi!
                I am Rice.
                \Backslash\ 'Single quotation' ""Dual quotation"" @at@
            ";
            Console.WriteLine(s05);

            string s06_1 = "Rice";
            string s06_2 = "Sam";
            string s06_3 = "Emma";
            string s06 = $"Family = {s06_1} + {s06_2} + {s06_3} + ...";
            Console.WriteLine(s06);

            string s07 = $"{{Bracket}}";
            Console.WriteLine(s07);
            Console.WriteLine("----------------------------------------");

            string s08 = "str_08";
            Console.WriteLine($"before UpdateInputString fun: {s08}");
            UpdateInputString(s08);
            Console.WriteLine($"after  UpdateInputString fun: {s08}");
        }

        private static void UpdateInputString(string inputStr)
        {
            inputStr = inputStr + "_updated";
            Console.WriteLine($"in the UpdateInputString fun: {inputStr}");
        }
    }
}

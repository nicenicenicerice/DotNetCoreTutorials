using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LangConsoleApp
{
    internal class Program11
    {
        public static void Run()
        {
            Console.WriteLine("C# - Data Types - Nullable Types");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-data-types");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-nullable-types");
            Console.WriteLine("----------------------------------------");

            Nullable<int> ni01 = null;
            PrintNullableIntInfo("ni01", ni01);

            int? ni02 = ni01;
            ni02 = 100;
            PrintNullableIntInfo("ni01", ni01);
            PrintNullableIntInfo("ni02", ni02);

            /* Compiler error
            int i03 = ni01;
            */

            int i03 = ni01 ?? 200;
            PrintNullableIntInfo("i03", i03);
            Console.WriteLine("----------------------------------------");

            int? ni_a = null;
            int i_b = 10;
            CompareUseOperator(ni_a, i_b);

            ni_a = 20;
            i_b = 10;
            CompareUseOperator(ni_a, i_b);

            ni_a = null;
            i_b = 10;
            CompareUseHelper(ni_a, i_b);
        }

        private static void PrintNullableIntInfo(string name, Nullable<int> ni)
        {
            if (ni.HasValue)
            {
                Console.WriteLine($"{name} = {ni} = {ni.Value}");
            }
            else
            {
                Console.WriteLine($"{name} is NULL ; default is {ni.GetValueOrDefault()}");
            }
        }

        private static void CompareUseOperator(int? ni_a, int i_b)
        {
            PrintNullableIntInfo("ni_a", ni_a);
            PrintNullableIntInfo("i_b", i_b);

            if (ni_a < i_b)
            {
                Console.WriteLine($"use operator: ni_a < i_b");
            }
            else if (ni_a > i_b)
            {
                Console.WriteLine($"use operator: ni_a > i_b");
            }
            else if (ni_a == i_b)
            {
                Console.WriteLine($"use operator: ni_a = i_b");
            }
            else
            {
                Console.WriteLine($"use operator: Could not compare.");
            }
        }

        private static void CompareUseHelper(int? ni_a, int i_b)
        {
            PrintNullableIntInfo("ni_a", ni_a);
            PrintNullableIntInfo("i_b", i_b);

            if (Nullable.Compare<int>(ni_a, i_b) < 0)
            {
                Console.WriteLine($"use helper: ni_a < i_b");
            }
            else if (Nullable.Compare<int>(ni_a, i_b) > 0)
            {
                Console.WriteLine($"use helper: ni_a > i_b");
            }
            else
            {
                Console.WriteLine($"use helper: ni_a = i_b");
            }
        }
    }
}
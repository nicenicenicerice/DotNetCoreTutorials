using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program26
    {
        public static void Run()
        {
            Console.WriteLine("C# - HashSet");
            Console.WriteLine("----------------------------------------");

            ISet<int> set01 = new HashSet<int>()
            {
                3, 3, 3, 2, 2, 1,
            };

            set01.Add(1);
            set01.Add(2);
            set01.Add(3);
            set01.Add(4);
            set01.Add(5);

            Console.WriteLine("set01:");
            for (int i = 0; i < set01.Count; i++)
            {
                int v = set01.ElementAt(i);
                Console.WriteLine($"Index = {i}；Value = {v}");
            }

            Console.WriteLine("set01:");
            foreach (int v in set01)
            {
                Console.WriteLine($"Value = {v}");
            }

            if (set01.Contains(10))
            {
                Console.WriteLine("set01 has Value = 10 .");
            }
            else
            {
                Console.WriteLine("set01 does not has Value = 10 .");
            }
        }
    }
}
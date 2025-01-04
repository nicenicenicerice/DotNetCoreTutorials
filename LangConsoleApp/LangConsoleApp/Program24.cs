using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program24
    {
        public static void Run()
        {
            Console.WriteLine("C# - SortedList<TKey, TValue>");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-sortedlist");
            Console.WriteLine("----------------------------------------");

            SortedList<int, string> pairList01 = new SortedList<int, string>()
            {
                { 5, "Five" },
                { 1, "One" },
                { 3, "Three" },
            };

            pairList01[7] = "Seven";
            pairList01[9] = "Nine";

            Console.WriteLine("pairList01:");
            for (int i = 0; i < pairList01.Count; i++)
            {
                int k = pairList01.Keys[i];
                string v = pairList01.Values[i];
                Console.WriteLine($"Index = {i}；Key = {k}；Value = {v}");
            }

            Console.WriteLine("pairList01:");
            foreach (KeyValuePair<int, string> pair in pairList01)
            {
                int k = pair.Key;
                string v = pair.Value;
                Console.WriteLine($"Key = {k}；Value = {v}");
            }

            if (pairList01.ContainsKey(10))
            {
                Console.WriteLine($"pairList01 has Key = 10 .");
            }
            else
            {
                Console.WriteLine($"pairList01 does not has Key = 10 .");
            }

            int key = 5;
            string val;
            if (pairList01.TryGetValue(key, out val))
            {
                Console.WriteLine($"pairList01 has Key = {key}, the Value is {val} .");
            }
            else
            {
                Console.WriteLine($"pairList01 does not has Key = {key} .");
            }
        }
    }
}

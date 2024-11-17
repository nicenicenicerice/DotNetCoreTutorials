using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program18
    {
        public static void Run()
        {
            Console.WriteLine("C# - Arrays - multi-dimensional array");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-multi-dimensional-array");
            Console.WriteLine("----------------------------------------");

            int[,] intArr2d = {
                { 1, 2, 3 },
                { 5, 6, 7 },
            };

            /* System.ArgumentException: 'Array was not a one-dimensional array.'
            for (int i = 0; i < intArr2d.Length; i++)
            {
                Console.Write($"intArr2d[{i}] = {intArr2d.GetValue(i)};");
            }
            Console.WriteLine();
            */

            int intArr2dIdx = 0;
            Console.Write($"intArr2d: ");
            foreach (int v in intArr2d)
            {
                Console.Write($"[{intArr2dIdx}] = {v} ; ");
                intArr2dIdx++;
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"intArr2d: ");
            for (int i = 0; i < intArr2d.GetLength(0); i++)
            {
                for (int j = 0; j < intArr2d.GetLength(1); j++)
                {
                    Console.Write($"[{i} , {j}] = {intArr2d[i, j]} ; ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            intArr2d[0, 0] = 10;
            intArr2d[0, 1] = 20;
            intArr2d[0, 2] = 30;
            intArr2d[1, 0] = 50;
            intArr2d[1, 1] = 60;
            intArr2d[1, 2] = 70;
            Console.WriteLine($"intArr2d: ");
            for (int i = 0; i < intArr2d.GetLength(0); i++)
            {
                for (int j = 0; j < intArr2d.GetLength(1); j++)
                {
                    Console.Write($"[{i} , {j}] = {intArr2d[i, j]} ; ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program19
    {
        public static void Run()
        {
            Console.WriteLine("C# - Arrays - Jagged Arrays: An Array of Array");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-jagged-array");
            Console.WriteLine("----------------------------------------");

            int[][] intArr01 = new int[2][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
            };

            Console.WriteLine("intArr01[][]:");
            for (int i = 0; i < intArr01.Length; i++)
            {
                for (int j = 0; j < intArr01[i].Length; j++)
                {
                    Console.WriteLine($"[{i}][{j}] = {intArr01[i][j]}");
                }
            }
            Console.WriteLine("----------------------------------------");

            int[][,] intArr02 = new int[2][,]
            {
                new int[,]
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 }
                },
                new int[,]
                {
                    { 9, 8, 7 },
                    { 6, 5, 4 }
                },
            };

            Console.WriteLine("intArr02[][,]:");
            for (int i = 0; i < intArr02.Length; i++)
            {
                for (int j = 0; j < intArr02[i].GetLength(0); j++)
                {
                    for (int k = 0; k < intArr02[i].GetLength(1); k++)
                    {
                        int v = intArr02[i][j, k];
                        Console.WriteLine($"[{i}][{j} , {k}] = {v}");
                    }
                }
            }
            Console.WriteLine("----------------------------------------");

            int[][] intArr03 =
            [
                [1, 2, 3],
                [4, 5, 6, 7, 8, 9],
            ];

            Console.WriteLine("intArr03[][]:");
            for (int i = 0; i < intArr03.Length; i++)
            {
                for (int j = 0; j < intArr03[i].Length; j++)
                {
                    Console.WriteLine($"[{i}][{j}] = {intArr03[i][j]}");
                }
            }
        }
    }
}

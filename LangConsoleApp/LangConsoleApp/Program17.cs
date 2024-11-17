using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program17
    {
        public static void Run()
        {
            Console.WriteLine("C# - Arrays - single-dimensional array");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/array-csharp");
            Console.WriteLine("----------------------------------------");

            int[] intArr01 = new int[5];
            int[] intArr02 = new int[5] { 1, 2, 3, 4, 5 };
            int[] intArr03 = { 1, 2, 3 };
            int[] intArr04;
            /* compiler error
            intArr04 = { 4, 5, 6 };
            */
            intArr04 = new int[] { 4, 5, 6 };
            int[] intArr05;
            intArr05 = [7, 8, 9];

            string[] strArr01 = { "Rice", "Sam", "Emma" };
            Console.WriteLine("----------------------------------------");

            int[] intArr06 = new int[3];
            intArr06[0] = 10;
            intArr06[1] = 20;
            Console.WriteLine($"intArr06[0] = {intArr06[0]}");
            Console.WriteLine($"intArr06[1] = {intArr06[1]}");
            Console.WriteLine($"intArr06[2] = {intArr06[2]}");
            Console.WriteLine("----------------------------------------");

            int[] intArr07 = { 1, 2, 3 };
            for (int i = 0; i < intArr07.Length; i++)
            {
                Console.WriteLine($"intArr07[{i}] = {intArr07[i]}");
            }

            int intArr07Idx = 0;
            foreach (int v in intArr07)
            {
                Console.WriteLine($"intArr07[{intArr07Idx}] = {v}");
                intArr07Idx++;
            }
            Console.WriteLine("----------------------------------------");

            int[] intArr08 = { 1, 3, 5 };
            intArr08.Max(); // using System.Linq
            intArr08.Min(); // using System.Linq
            intArr08.Sum(); // using System.Linq
            PrintIntArrayInfo("intArr08", intArr08);
            Console.WriteLine($"intArr08: Max = {intArr08.Max()}；Min = {intArr08.Min()}；Sum = {intArr08.Sum()}");
            Console.WriteLine("----------------------------------------");

            int[] intArr09 = { 6, 8, 2, 4 };
            PrintIntArrayInfo("intArr09", intArr09);

            Array.Sort(intArr09);
            PrintIntArrayInfo("intArr09", intArr09);

            Array.Reverse(intArr09);
            PrintIntArrayInfo("intArr09", intArr09);
            Console.WriteLine("----------------------------------------");

            int[] intArr10 = { 2, 4, 6 };
            Console.WriteLine("intArr10: before UpdateInputIntArray fun:");
            PrintIntArrayInfo("intArr10", intArr10);
            UpdateInputIntArray(intArr10);
            Console.WriteLine("intArr10: after  UpdateInputIntArray fun:");
            PrintIntArrayInfo("intArr10", intArr10);
        }

        private static void UpdateInputIntArray(int[] intArr)
        {
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] *= intArr[i];
            }
        }

        private static void PrintIntArrayInfo(string name, int[] intArr)
        {
            Console.Write($"{name}: ");
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write($"[{i}] = {intArr[i]}; ");
            }
            Console.WriteLine();
        }
    }
}

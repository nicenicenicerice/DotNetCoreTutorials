using LangConsoleApp.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program08
    {
        public static void Run()
        {
            Console.WriteLine("C# - Data Types - Enum");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-data-types");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-enum");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine($"Enum: {typeof(ACategory)}");
            foreach (ACategory c in Enum.GetValues(typeof(ACategory)))
            {
                int v = Convert.ToInt32(c);
                Console.WriteLine($"{c} = {v}");
            }

            Console.WriteLine($"Enum: {typeof(BCategory)}");
            foreach (BCategory c in Enum.GetValues(typeof(BCategory)))
            {
                int v = Convert.ToInt32(c);
                Console.WriteLine($"{c} = {v}");
            }

            Console.WriteLine($"Enum: {typeof(CCategory)}");
            foreach (CCategory c in Enum.GetValues(typeof(CCategory)))
            {
                int v = Convert.ToInt32(c);
                Console.WriteLine($"{c} = {v}");
            }

            Console.WriteLine($"Enum: {typeof(FlagCategory)}");
            foreach (FlagCategory c in Enum.GetValues(typeof(FlagCategory)))
            {
                int v = Convert.ToInt32(c);
                Console.WriteLine($"{c} = {v}");
            }
            Console.WriteLine("----------------------------------------");

            ACategory aCategory = ACategory.A1;
            switch (aCategory)
            {
                case ACategory.A0:
                    Console.WriteLine($"the enum is {aCategory}");
                    break;
                case ACategory.A1:
                    Console.WriteLine($"the enum is {aCategory}");
                    break;
                case ACategory.A2:
                    Console.WriteLine($"the enum is {aCategory}");
                    break;
            }
        }
    }
}

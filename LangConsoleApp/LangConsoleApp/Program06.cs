using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LangConsoleApp
{
    internal class Program06
    {
        public static void Run()
        {
            Console.WriteLine("C# - Data Types - DateTime：");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-data-types");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-datetime");
            Console.WriteLine("----------------------------------------");

            DateTime dt01 = new DateTime();
            PrintInfo("dt01", dt01);

            DateTime dt02 = DateTime.Today;
            PrintInfo("dt02", dt02);

            DateTime dt03 = DateTime.Now;
            PrintInfo("dt03", dt03);

            DateTime dt04 = DateTime.UtcNow;
            PrintInfo("dt04", dt04);

            DateTime dt05 = new DateTime(2024, 1, 1);
            PrintInfo("dt05", dt05);

            DateTime dt06 = new DateTime(2024, 1, 1, 13, 30, 45);
            PrintInfo("dt06", dt06);
            Console.WriteLine("----------------------------------------");

            DateTime dt07 = new DateTime(2024, 1, 1, 8, 0, 0);
            PrintInfo("dt07", dt07);

            DateTime dt08;
            Console.WriteLine("----------------------------------------");

            Console.WriteLine($"DateTime: MinValue = {DateTime.MinValue}；MinValueTick = {DateTime.MinValue.Ticks}");
            Console.WriteLine($"DateTime: MaxValue = {DateTime.MaxValue}；MaxValueTick = {DateTime.MaxValue.Ticks}");
        }

        private static void PrintInfo(string name, DateTime dateTime)
        {
            Console.WriteLine($"{name}: Value = {dateTime}；Kind = {dateTime.Kind}；Tick = {dateTime.Ticks}");
        }
    }
}

using LangConsoleApp.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program16
    {
        public static void Run()
        {
            Console.WriteLine("C# - Static Class, Methods, Constructors, Fields");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-static");
            Console.WriteLine("----------------------------------------");

            /* Compiler Error CS0723
            Calculator calculator = new Calculator();
            */

            Console.WriteLine($"Calculator: Code = {Calculator.Code}；Name = {Calculator.Name}");
            Console.WriteLine($"Calculator: A = 10, B = 20, A + B = {Calculator.Sum(10, 20)}");
            Console.WriteLine("----------------------------------------");

            Counter counter1 = new Counter("Counter_1");
            Counter.PlusOne();
            Counter.DisplayCounterTotal();

            Counter counter2 = new Counter("Counter_2");
            Counter.PlusOne();
            Counter.DisplayCounterTotal();
        }
    }
}

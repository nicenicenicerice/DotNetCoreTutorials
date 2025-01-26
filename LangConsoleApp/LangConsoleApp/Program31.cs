using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LangConsoleApp
{
    internal class Program31
    {
        public static void Run()
        {
            Console.WriteLine("C# - Func Delegate and Action Delegate and Predicate Delegate");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-func-delegate");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-action-delegate");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-predicate");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(1):");

            Func<int> func01;

            func01 = delegate ()
            {
                return 1;
            };
            Console.WriteLine($"func01-1:{func01()}");

            func01 = () => 2;
            Console.WriteLine($"func01-2:{func01()}");

            Func<int, int> func02;
            func02 = (int inParam) => inParam + 100;
            int func02InParam = 1;
            int func02OutParam = func02(func02InParam);
            Console.WriteLine($"func02:inParam = {func02InParam}；outParam = {func02OutParam}");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(2):");

            Action action01 = () =>
            {
                Console.WriteLine($"action01:(2-1)");
            };
            action01();

            Action<int> action02 = (int inParam) =>
            {
                Console.WriteLine($"action02:(2-2)；inParam = {inParam}");
            };
            action02(1000);
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(3):");

            Predicate<string> predicateIsUpper = (string text) =>
            {
                return text == text.ToUpper();
            };
            string predicateIsUpperText = "hello world!";
            Console.WriteLine($"predicateIsUpper:inText = {predicateIsUpperText}；outBool = {predicateIsUpper(predicateIsUpperText)}");
        }
    }
}

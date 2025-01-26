using LangConsoleApp.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program30
    {
        public static void Run()
        {
            Console.WriteLine("C# - Delegates");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-delegates");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(1):");
            MyDelegate01 delegate01;

            delegate01 = MethodA;
            delegate01("delegate01:(1-1)");

            delegate01 = (string msg) => { Console.WriteLine($"MyDelegate01 as Lambda Expression = {msg}"); };
            delegate01("delegate01:(1-2)");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(2):");

            InvokeDelegate(MethodA, "(2-1)");

            InvokeDelegate(
                (string msg) =>
                {
                    Console.WriteLine($"MyDelegate01 as Lambda Expression = {msg}");
                },
                "(2-2)"
            );
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(3):");

            MyDelegate01 delegate03;

            MyDelegate01 delegate03A = ClazzA.MethodA1;
            MyDelegate01 delegate03B = ClazzB.MethodB1;

            delegate03 = delegate03A + delegate03B;
            delegate03("(3-1)");
            Console.WriteLine();

            delegate03 += delegate03A;
            delegate03("(3-2)");
            Console.WriteLine();

            delegate03 -= delegate03A;
            delegate03("(3-3)");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(4):");

            MyDelegate02 delegate04;

            MyDelegate02 delegate04A = ClazzA.MethodA2;
            MyDelegate02 delegate04B = ClazzB.MethodB2;

            delegate04 = delegate04A + delegate04B;
            string delegate04Result = delegate04();
            Console.WriteLine($"delegate04:{delegate04Result}");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(5):");

            MyDelegate03<int> delegate05A = Sum;
            int delegate05AResult = Sum(1, 2);
            Console.WriteLine($"delegate05A:{delegate05AResult}");

            MyDelegate03<string> delegate05B = Concat;
            string delegate05BResult = Concat("A", "B");
            Console.WriteLine($"delegate05B:{delegate05BResult}");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(6):");

            ClazzC clazzC = new ClazzC();
            MyDelegate01 delegate061 = clazzC.MethodC;
            delegate061("(6-1)");

            MyDelegate01 delegate062 = GetDelegateByTempClazzCMethodC();
            delegate062("(6-2)");
        }

        internal static void MethodA(string msg)
        {
            Console.WriteLine($"MyDelegate01 as MethodA fun = {msg}");
        }

        internal static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        internal static string Concat(string text1, string text2)
        {
            return text1 + text2;
        }

        internal static void InvokeDelegate(MyDelegate01 myDelegate, string msg)
        {
            myDelegate($"InvokeDelegate:{msg}");
        }

        internal static MyDelegate01 GetDelegateByTempClazzCMethodC()
        {
            ClazzC tmpClazzC = new ClazzC();
            MyDelegate01 myDelegate = tmpClazzC.MethodC;
            return myDelegate;
        }
    }

    internal class ClazzA
    {
        public static void MethodA1(string message)
        {
            Console.WriteLine("Called ClazzA.MethodA1() with parameter: " + message);
        }

        public static string MethodA2()
        {
            return "ClazzA.MethodA2";
        }
    }

    internal class ClazzB
    {
        public static void MethodB1(string message)
        {
            Console.WriteLine("Called ClazzB.MethodB1() with parameter: " + message);
        }

        public static string MethodB2()
        {
            return "ClazzB.MethodB2";
        }
    }

    internal class ClazzC
    {
        public void MethodC(string message)
        {
            Console.WriteLine("Called instanceOfClazzC.MethodC() with parameter: " + message);
        }
    }
}

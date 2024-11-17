using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program02
    {
        public static void Run()
        {
            Console.WriteLine("C# Namespace：");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/namespace");
            Console.WriteLine("----------------------------------------");

            Schools.Teacher teacher = new Schools.Teacher(101, "Sam");
            Console.WriteLine("Description: " + teacher.GetDescription("I am tall."));

            Schools.Devices.BlackBoard blackBoard = new Schools.Devices.BlackBoard();
            Console.WriteLine("Description: " + blackBoard.GetDescription());
        }
    }
}

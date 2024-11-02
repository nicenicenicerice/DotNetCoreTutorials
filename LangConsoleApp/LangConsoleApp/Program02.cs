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

            School.Teacher teacher = new School.Teacher(101, "Sam");
            Console.WriteLine("Description: " + teacher.GetDescription("I am tall."));

            School.Device.BlackBoard blackBoard = new School.Device.BlackBoard();
            Console.WriteLine("Description: " + blackBoard.GetDescription());
        }
    }
}

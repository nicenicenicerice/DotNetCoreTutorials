using LangConsoleApp.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program01
    {
        public static void Run()
        {
            Console.WriteLine("C# Class and Objects：");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-class");
            Console.WriteLine("----------------------------------------");

            Student student = new Student();
            student.Id = 1;
            student.Name = "Rice";
            student.SeatNo = 123;
            student.Greet();
            Console.WriteLine("Description: " + student.GetDescription("I am cool."));
            Console.WriteLine("----------------------------------------");

            Teacher teacher = new Teacher(101, "Sam");
            teacher.Greet();
            Console.WriteLine("Description: " + teacher.GetDescription("I am tall."));
        }
    }
}

using LangConsoleApp.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program12
    {
        public static void Run()
        {
            Console.WriteLine("C# - Value Type and Reference Type");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-value-type-and-reference-type");
            Console.WriteLine("----------------------------------------");

            int v = 10;
            Console.WriteLine($"before ChangeValueType: {v}");
            ChangeValueType(v);
            Console.WriteLine($"after  ChangeValueType: {v}");
            Console.WriteLine("----------------------------------------");

            Student student = new Student();
            student.Id = 1;
            student.Name = "Rice";
            student.SeatNo = 10;
            Console.WriteLine(student.GetDescription("before ChangeReferenceType"));
            ChangeReferenceType(student);
            Console.WriteLine(student.GetDescription("after  ChangeReferenceType"));
            Console.WriteLine("----------------------------------------");

            string s = "A";
            Console.WriteLine($"before ChangeImmutableStringReferenceType: {s}");
            ChangeImmutableStringReferenceType(s);
            Console.WriteLine($"after  ChangeImmutableStringReferenceType: {s}");
        }

        private static void ChangeValueType(int v)
        {
            v = 20;
            Console.WriteLine($"in the ChangeValueType: {v}");
        }

        private static void ChangeReferenceType(Student student)
        {
            student.Name = "Ping";
            Console.WriteLine(student.GetDescription("in the ChangeReferenceType"));
        }

        private static void ChangeImmutableStringReferenceType(string s)
        {
            s = "B";
            Console.WriteLine($"in the ChangeImmutableStringReferenceType: {s}");
        }
    }
}

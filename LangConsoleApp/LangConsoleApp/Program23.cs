using LangConsoleApp.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program23
    {
        public static void Run()
        {
            Console.WriteLine("C# - List<T>");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-list");
            Console.WriteLine("----------------------------------------");

            IList<int> intList01 = new List<int>() { 1, 2, 3 };

            IList<int> intList02 = new List<int>();
            intList02.Add(4);
            intList02.Add(5);
            intList02.Add(6);

            for (int i = 0; i < intList02.Count; i++)
            {
                int num = intList02[i];
                intList02[i] = num + 10;
            }

            foreach (int v in intList02)
            {
                int num = v;
            }

            List<string> strList03 = new List<string>() { "ABC", "DEF" };
            Console.WriteLine("strList03:");
            strList03.ForEach(v => v += "_updated");
            strList03.ForEach(v => Console.Write(v + ","));
            Console.WriteLine();

            List<Student> studentList04 = new List<Student>()
            {
                new Student() { Id = 1, Name = "Rice", SeatNo = 1 },
                new Student() { Id = 2, Name = "Sam",  SeatNo = 2 },
                new Student() { Id = 3, Name = "Emma", SeatNo = 3 },
            };
            Console.WriteLine("studentList04:");
            studentList04.ForEach(v => v.SeatNo += 10);
            studentList04.ForEach(v => Console.WriteLine($"Id = {v.Id}；SeatNo = {v.SeatNo}；Name = {v.Name}"));
            Console.WriteLine();

            var studentList05 = from s in studentList04
                                where s.Name == "Sam"
                                select new { StudentId = s.Id, StudentName = s.Name };
            foreach (var student in studentList05)
            {
                int id = student.StudentId;
                string name = student.StudentName;
            }
        }
    }
}

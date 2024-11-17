using LangConsoleApp.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LangConsoleApp
{
    internal class Program09
    {
        public static void Run()
        {
            Console.WriteLine("C# - Data Types - Anonymous Type");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-data-types");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-anonymous-type");
            Console.WriteLine("----------------------------------------");

            var person = new { Id = "H001", Name = "Rice" };
            Console.WriteLine($"person type: {person.GetType()}");

            /* Error: cannot change the read-only value.
            person.Name = "UpdatedName";
            */

            var persons = new[] {
                new { Id = "H002", Name = "Sam" },
                new { Id = "H003", Name = "Emma" },
            };
            Console.WriteLine("----------------------------------------");

            IList<Student> students = new List<Student>() {
                new Student() {Id = 1, Name = "Rice", SeatNo = 1},
                new Student() {Id = 2, Name = "Sam",  SeatNo = 2},
                new Student() {Id = 3, Name = "Emma", SeatNo = 3},
            };

            var studentInfoList = from s in students
                                  select new { StudentId = s.Id, StudentName = s.Name }
            ;

            Console.WriteLine($"student info list:");
            foreach (var student in studentInfoList)
            {
                Console.WriteLine($"student info: StudentId = {student.StudentId} ; StudentName = {student.StudentName}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Schools
{
    internal class Teacher
    {
        public const string SCHOOL_NAME = "某市國小";

        public int Id = 0;

        public string Name { get; set; } = "空";

        public Teacher(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Greet()
        {
            Console.WriteLine($"{Name}: I love teaching!");
        }

        public string GetDescription(string memo)
        {
            return $"Teacher: ID = {Id}；Name = {Name}；Memo = {memo}";
        }
    }
}

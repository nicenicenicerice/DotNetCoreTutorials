using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Schools
{
    internal class Student
    {
        public const string SCHOOL_NAME = "某市國小";

        public int Id = 0;

        public string Name { get; set; } = "空";

        private int _seatNo;

        public int SeatNo
        {
            get { return _seatNo; }
            set { _seatNo = value; }
        }

        public void Greet()
        {
            Console.WriteLine($"{Name}: I love learning!");
        }

        public string GetDescription(string memo)
        {
            return $"Student: ID = {Id}；Name = {Name}；Memo = {memo}";
        }
    }
}

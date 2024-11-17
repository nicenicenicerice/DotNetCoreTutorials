using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Machines
{
    internal partial class Engine
    {
        partial void Init()
        {
            Console.WriteLine($"Engine initializing ... : Code = {Code}；Name = {Name}");
            Console.WriteLine("...");
            Console.WriteLine("Engine initialization completed.");
        }

        public string GetDescription(string memo)
        {
            return $"Engine: Code = {Code}；Name = {Name}；Memo = {memo}";
        }
    }
}

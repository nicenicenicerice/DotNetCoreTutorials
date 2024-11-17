using LangConsoleApp.Superpowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Heros
{
    internal class Hulk : IBehaviorA, IBehaviorB
    {
        public void DoActionOne()
        {
            Console.WriteLine("Hulk.DoActionOne");
        }

        public void DoActionTwo(int param)
        {
            Console.WriteLine($"Hulk.DoActionTwo: param = {param}");
        }
    }
}

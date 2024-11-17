using LangConsoleApp.Superpowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Heros
{
    internal class Batman : IBehaviorA, IBehaviorB
    {
        void IBehaviorA.DoActionOne()
        {
            Console.WriteLine("Batman.IBehaviorA.DoActionOne");
        }

        void IBehaviorB.DoActionOne()
        {
            Console.WriteLine("Batman.IBehaviorB.DoActionOne");
        }

        void IBehaviorA.DoActionTwo(int param)
        {
            Console.WriteLine($"Batman.IBehaviorA.DoActionTwo: param = {param}");
        }

        void IBehaviorB.DoActionTwo(int param)
        {
            Console.WriteLine($"Batman.IBehaviorB.DoActionTwo: param = {param}");
        }
    }
}

using LangConsoleApp.Superpowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Heros
{
    internal class Spiderman : IBehaviorC
    {
        public void DoActionThree()
        {
            Console.WriteLine("Spiderman.DoActionThree");
        }

        public void DoActionFour()
        {
            Console.WriteLine("Spiderman.DoActionFour");
        }
    }
}

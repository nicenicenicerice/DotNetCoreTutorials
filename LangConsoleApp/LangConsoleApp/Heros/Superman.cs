using LangConsoleApp.Superpowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Heros
{
    internal class Superman : IBehaviorA
    {
        /* Compiler Error CS0737 
         * 'type name' does not implement interface member 'member name'. 'method name' cannot implement an interface member because it is not public.
         * A method that implements an interface member must have public accessibility. All interface members are public.
        void DoActionOne()
        {
            throw new NotImplementedException();
        }

        void DoActionTwo(int param)
        {
            throw new NotImplementedException();
        }
        */

        public void DoActionOne()
        {
            Console.WriteLine("Superman.DoActionOne");
        }

        public void DoActionTwo(int param)
        {
            Console.WriteLine($"Superman.DoActionTwo: param = {param}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Superpowers
{
    internal interface IBehaviorC
    {
        void DoActionThree();

        void DoActionFour() // virtual and default method
        {
            Console.WriteLine("IBehaviorC.DoActionFour");
        }

        void DoActionFive() // virtual and default method
        {
            Console.WriteLine("IBehaviorC.DoActionFive");
        }
    }
}

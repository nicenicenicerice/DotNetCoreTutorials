using LangConsoleApp.Heros;
using LangConsoleApp.Superpowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LangConsoleApp
{
    internal class Program13
    {
        public static void Run()
        {
            Console.WriteLine("C# - Interface");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-interface");
            Console.WriteLine("----------------------------------------");

            Superman superman01 = new Superman();
            superman01.DoActionOne();
            superman01.DoActionTwo(1);

            IBehaviorA behaviorA01 = new Superman();
            behaviorA01.DoActionOne();
            behaviorA01.DoActionTwo(1);
            Console.WriteLine("----------------------------------------");

            Batman batman02 = new Batman();
            /* Compiler Error CS1061
            batman02.DoActionOne();
            batman02.DoActionTwo(2);
            */

            IBehaviorA behaviorA02 = new Batman();
            behaviorA02.DoActionOne();
            behaviorA02.DoActionTwo(2);

            IBehaviorB behaviorB02 = new Batman();
            behaviorB02.DoActionOne();
            behaviorB02.DoActionTwo(2);
            Console.WriteLine("----------------------------------------");

            Hulk hulk03 = new Hulk();
            hulk03.DoActionOne();
            hulk03.DoActionTwo(3);

            IBehaviorA behaviorA03 = new Hulk();
            behaviorA03.DoActionOne();
            behaviorA03.DoActionTwo(3);

            IBehaviorB behaviorB03 = new Hulk();
            behaviorB03.DoActionOne();
            behaviorB03.DoActionTwo(3);
            Console.WriteLine("----------------------------------------");

            Spiderman spiderman04 = new Spiderman();
            spiderman04.DoActionThree();
            spiderman04.DoActionFour();
            /* Compiler Error CS1061
            spiderman04.DoActionFive();
            */

            IBehaviorC behaviorC04 = new Spiderman();
            behaviorC04.DoActionThree();
            behaviorC04.DoActionFour();
            behaviorC04.DoActionFive();
        }
    }
}

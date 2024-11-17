using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Tools
{
    internal static class Calculator
    {
        public static string Code = "XXXX";

        public static string Name { get; set; } = "Calculator";

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}

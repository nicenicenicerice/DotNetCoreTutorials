using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program04
    {
        public static void Run()
        {
            Console.WriteLine("C# - Data Types - Numbers");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-data-types");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/numbers");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Integer type----------------------------");
            byte i01 = 0;
            sbyte i02 = 0;
            short i03 = 0;
            ushort i04 = 0;
            int i05 = 0;
            uint i06 = 0U;
            long i07 = 0L;
            ulong i08 = 0UL;
            int i09 = 0x2F;
            int i10 = 0b_0010_1111;
            Console.WriteLine("byte   :" + byte.MinValue + "-" + byte.MaxValue);
            Console.WriteLine("sbyte  :" + sbyte.MinValue + "-" + sbyte.MaxValue);
            Console.WriteLine("short  :" + short.MinValue + "-" + short.MaxValue);
            Console.WriteLine("ushort :" + ushort.MinValue + "-" + ushort.MaxValue);
            Console.WriteLine("int    :" + int.MinValue + "-" + int.MaxValue);
            Console.WriteLine("uint   :" + uint.MinValue + "-" + uint.MaxValue);
            Console.WriteLine("long   :" + long.MinValue + "-" + long.MaxValue);
            Console.WriteLine("ulong  :" + ulong.MinValue + "-" + ulong.MaxValue);

            Console.WriteLine("Floating-point type---------------------");
            float f01 = 0.0F;
            double f02 = 0.0D;
            double f03 = 0.0;
            decimal f04 = 0.0M;
            float f05 = 123e2F;
            double f06 = 123e-2D;
            decimal f07 = 123e2M;
            Console.WriteLine("float  :" + float.MinValue + "-" + float.MaxValue);
            Console.WriteLine("double :" + double.MinValue + "-" + double.MaxValue);
            Console.WriteLine("decimal:" + decimal.MinValue + "-" + decimal.MaxValue);
        }
    }
}

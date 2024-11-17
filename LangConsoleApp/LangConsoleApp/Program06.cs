using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LangConsoleApp
{
    internal class Program06
    {
        public static void Run()
        {
            Console.WriteLine("C# - Data Types - DateTime：");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-data-types");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-datetime");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine($"DateTime: MinValue = {DateTime.MinValue}；MinValueTick = {DateTime.MinValue.Ticks}");
            Console.WriteLine($"DateTime: MaxValue = {DateTime.MaxValue}；MaxValueTick = {DateTime.MaxValue.Ticks}");
            Console.WriteLine("----------------------------------------");

            DateTime dt01 = new DateTime();
            PrintInfo("dt01", dt01);

            DateTime dt02 = DateTime.Today;
            PrintInfo("dt02", dt02);

            DateTime dt03 = DateTime.Now;
            PrintInfo("dt03", dt03);

            DateTime dt04 = DateTime.UtcNow;
            PrintInfo("dt04", dt04);

            DateTime dt05 = new DateTime(2024, 1, 1);
            PrintInfo("dt05", dt05);

            DateTime dt06 = new DateTime(2024, 1, 1, 13, 30, 45);
            PrintInfo("dt06", dt06);
            Console.WriteLine("----------------------------------------");

            DateTime dt07_unspecified = new DateTime(2024, 1, 1, 8, 0, 0, DateTimeKind.Unspecified);
            PrintInfo("dt07_unspecified", dt07_unspecified);

            DateTime dt07_utc = new DateTime(2024, 1, 1, 8, 0, 0, DateTimeKind.Utc);
            PrintInfo("dt07_utc", dt07_utc);

            DateTime dt07_local = new DateTime(2024, 1, 1, 8, 0, 0, DateTimeKind.Local);
            PrintInfo("dt07_local", dt07_local);

            DateTime dt08_unspecifiedToLocal = dt07_unspecified.ToLocalTime();
            PrintInfo("dt08_unspecifiedToLocal", dt08_unspecifiedToLocal);

            DateTime dt08_unspecifiedToUtc = dt07_unspecified.ToUniversalTime();
            PrintInfo("dt08_unspecifiedToUtc", dt08_unspecifiedToUtc);

            DateTime dt09_utcToLocal = dt07_utc.ToLocalTime();
            PrintInfo("dt09_utcToLocal", dt09_utcToLocal);

            DateTime dt09_utcToUtc = dt07_utc.ToUniversalTime();
            PrintInfo("dt09_utcToUtc", dt09_utcToUtc);

            DateTime dt10_localToLocal = dt07_local.ToLocalTime();
            PrintInfo("dt10_localToLocal", dt10_localToLocal);

            DateTime dt10_localToUtc = dt07_local.ToUniversalTime();
            PrintInfo("dt10_localToUtc", dt10_localToUtc);
            Console.WriteLine("----------------------------------------");

            DateTime dt11 = new DateTime(2024, 1, 1);
            PrintInfo("dt11", dt11);

            DateTime dt12_addTimeSpan = dt11.Add(new TimeSpan(10, 20, 30));
            PrintInfo("dt12_addTimeSpan", dt12_addTimeSpan);

            DateTime dt12_subtractTimeSpan = dt11.Subtract(new TimeSpan(1, 5, 10));
            PrintInfo("dt12_subtractTimeSpan", dt12_subtractTimeSpan);
            Console.WriteLine("----------------------------------------");

            DateTime dt13_a = new DateTime(2024, 1, 1);
            PrintInfo("dt13_a", dt13_a);

            DateTime dt13_b = new DateTime(2024, 1, 2, 10, 20, 30);
            PrintInfo("dt13_b", dt13_b);

            TimeSpan ts13 = new TimeSpan(1, 0, 0);
            Console.WriteLine($"TimeSpan: ts13 = {ts13}");

            TimeSpan ts14_dt13b_subtract_dt13a = dt13_b - dt13_a;
            Console.WriteLine($"TimeSpan: dt13_b - dt13_a = {ts14_dt13b_subtract_dt13a}");

            DateTime dt14_dt13a_add_ts13 = dt13_a + ts13;
            PrintInfo("dt14_dt13a_add_ts13", dt14_dt13a_add_ts13);

            Console.WriteLine($"dt13_a == dt13_b : {dt13_a == dt13_b}");
            Console.WriteLine($"dt13_a != dt13_b : {dt13_a != dt13_b}");
            Console.WriteLine($"dt13_a >  dt13_b : {dt13_a > dt13_b}");
            Console.WriteLine($"dt13_a <  dt13_b : {dt13_a < dt13_b}");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("String to DateTime:");
            Console.WriteLine("(1)Parse(): ...");
            Console.WriteLine("(2)ParseExact(): ...");
            Console.WriteLine("(3)TryParse(): ...");
            Console.WriteLine("(4)TryParseExact():");

            string dtStr_yyyymmdd = "2024-01-01";
            string dtStr_bad = "abc";
            string dtStr_null = null;

            StringToDateTimeUseTryParseExact(dtStr_yyyymmdd);
            StringToDateTimeUseTryParseExact(dtStr_bad);
            StringToDateTimeUseTryParseExact(dtStr_null);
        }

        private static void StringToDateTimeUseTryParseExact(string dtStr)
        {
            string dtStrText = dtStr == null ? "NULL" : dtStr;

            DateTime resultDt;
            bool isValidDtFormat = DateTime.TryParseExact(
                dtStr,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out resultDt
            );

            string validDtFormatText = isValidDtFormat ? "Y" : "N";
            Console.WriteLine($"string = {dtStrText}；valid datetime format = {validDtFormatText}");
        }

        private static void PrintInfo(string name, DateTime dateTime)
        {
            Console.WriteLine($"{name}: Value = {dateTime}；Kind = {dateTime.Kind}；Tick = {dateTime.Ticks}");
        }
    }
}

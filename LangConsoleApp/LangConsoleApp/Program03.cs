namespace LangConsoleApp
{
    internal class Program03
    {
        public static void Run()
        {
            Console.WriteLine("C# - var：");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-var-implicit-typed-local-variable");
            Console.WriteLine("----------------------------------------");

            var a = 10;
            Console.WriteLine($"a: " + a.GetType());

            var b = 100.0;
            Console.WriteLine($"b: " + b.GetType());

            var c = 200.0F;
            Console.WriteLine($"c: " + c.GetType());

            var d = "cool";
            Console.WriteLine($"d: " + d.GetType());

            var e = new string[] { "A", "B", "C" };
            Console.WriteLine($"e: " + e.GetType());

            var f = new { Id = 1, Name = "Rice" };
            Console.WriteLine($"f: " + f.GetType());

            /* Compile-time error
            var g;
            g = 0;

            var i = 100, j = 200, k = 300;
            */
            Console.WriteLine("----------------------------------------");

            // LINQ
            List<string> list = new List<string>() {
                "LA", "LB", "LC",
            };
            var result = from s in list
                         where s.Contains("B")
                         select s;
            Console.WriteLine($"LINQ result count = {result.Count()}");
        }
    }
}

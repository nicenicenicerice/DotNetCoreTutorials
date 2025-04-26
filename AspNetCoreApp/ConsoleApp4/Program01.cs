using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program01
    {
        public void Run()
        {
            Console.WriteLine("ASP NET CORE - Middleware - chain simulation");

            List<Func<Action, Action>> middlewares = new List<Func<Action, Action>>();

            int num = 1;
            for (int i = 0; i < 5; i++)
            {
                Func<Action, Action> middleware = next =>
                {
                    return () =>
                    {
                        Console.WriteLine($"num = {num++}");
                        next();
                    };
                };

                middlewares.Add(middleware);
            }

            Action last = () =>
            {
                Console.WriteLine("last");
            };

            Action app = last;
            for (int i = (5 - 1); i >= 0; i--)
            {
                app = middlewares[i](app);
            }

            app();
        }
    }
}

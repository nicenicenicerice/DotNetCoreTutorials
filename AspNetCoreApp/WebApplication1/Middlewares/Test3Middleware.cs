
using System.Security.Cryptography;
using System.Xml.Linq;

namespace WebApplication1.Middlewares
{
    public class Test3Middleware : IMiddleware
    {
        public Test3Middleware(/* optional DI */)
        {
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine($"middleware: test-3 with condition");

            await next(context);
        }
    }
}

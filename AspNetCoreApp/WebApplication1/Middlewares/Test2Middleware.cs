
using System.Security.Cryptography;
using System.Xml.Linq;

namespace WebApplication1.Middlewares
{
    public class Test2Middleware : IMiddleware
    {
        public Test2Middleware(/* optional DI */)
        {
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine($"middleware: test-2");

            await next(context);
        }
    }
}

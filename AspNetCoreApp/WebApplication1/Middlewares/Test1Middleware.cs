
namespace WebApplication1.Middlewares
{
    public class Test1Middleware
    {
        private RequestDelegate _next;
        private int _id;
        private string _name;
        private string _description;

        public Test1Middleware(RequestDelegate next, int id, string name, string description)
        {
            _next = next;
            _id = id;
            _name = name;
            _description = description;
        }

        public async Task InvokeAsync(HttpContext context /* optional DI */)
        {
            Console.WriteLine($"middleware: test-1 : ID = {_id} ; Name = {_name} ; Description = {_description}");

            await _next(context);
        }
    }
}

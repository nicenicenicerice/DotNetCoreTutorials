using WebApplication1.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<Test2Middleware>(); // <--
builder.Services.AddScoped<Test3Middleware>(); // <--

var app = builder.Build();

// method (1)
app.Use(async (context, next) =>
{
    Console.WriteLine("middleware: first");
    await next(context);
});

// method (2)
app.UseMiddleware<Test1Middleware>(1, "Test1", "Middleware");

// method (3)
app.UseMiddleware<Test2Middleware>();

// method with condition - 1
app.UseWhen(context =>
{
    if (context.Request.Query.TryGetValue("test3", out var test3))
    {
        if (test3 == "1")
        {
            return true;
        }
    }

    return false;
}, appBuilder =>
{
    appBuilder.UseMiddleware<Test3Middleware>();
});

// method with condition - 2
app.UseWhen(context =>
{
    if (context.Request.Query.TryGetValue("test3", out var test3))
    {
        if (test3 == "2")
        {
            return true;
        }
    }

    return false;
}, appBuilder =>
{
    appBuilder.Run(async context =>
    {
        Console.WriteLine("middleware: test-3 with condition - 2");
        await context.Response.WriteAsync("test-3 with condition - 2");
    });
});

// method (1)
app.Use(async (context, next) =>
{
    Console.WriteLine("middleware: end");
    await next();
});

app.MapGet("/", () => "Hello World!");

app.MapGet("/A", (HttpContext context) =>
{
    Endpoint? endpoint = context.GetEndpoint();

    if (endpoint == null)
    {
        return "Endpoint is null";
    }

    String displayName = endpoint.DisplayName ?? "no display name";

    Version? version = endpoint.Metadata.GetMetadata<Version>();
    String versionText = version?.ToString() ?? "no version";

    String? author = endpoint.Metadata.GetMetadata<String>();
    author ??= "no author";

    return $"Endpoint: {displayName} ; version = {versionText} ; author = {author}";

})
.WithDisplayName("A-Routing")
.WithMetadata(new Version(1, 3, 5), "Rice");

app.Run();

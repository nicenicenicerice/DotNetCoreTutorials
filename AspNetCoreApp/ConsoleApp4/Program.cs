// See https://aka.ms/new-console-template for more information

Console.WriteLine("ASP NET CORE");
Console.WriteLine("參考自：開源 Web 建置強大標準，ASP.NET Core，周家安 編著");
Console.WriteLine();

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
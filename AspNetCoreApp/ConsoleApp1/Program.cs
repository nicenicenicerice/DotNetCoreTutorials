// See https://aka.ms/new-console-template for more information
using ConsoleApp.Implementations;
using ConsoleApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("ConsoleApp1:");

IServiceCollection services = new ServiceCollection();

services.AddSingleton<IFormatWriter, JsonFormatWriter>();
services.AddSingleton<IFormatWriter, XmlFormatWriter>();
services.AddSingleton<IRespOutput>(provider =>
{
    return new RespOutput(new JsonFormatWriter());
});

IServiceProvider serviceProvider = services.BuildServiceProvider();

// (1)
IFormatWriter writer = serviceProvider.GetRequiredService<IFormatWriter>();
Console.WriteLine(writer.Write("(1)"));
Console.WriteLine();

// (2)
IEnumerable<IFormatWriter> writers = serviceProvider.GetServices<IFormatWriter>();
foreach (IFormatWriter w in writers)
{
    Console.WriteLine(w.Write("(2)"));
}
Console.WriteLine();

// (3)
IRespOutput output = serviceProvider.GetRequiredService<IRespOutput>();
output.Output("(3)");
Console.WriteLine();

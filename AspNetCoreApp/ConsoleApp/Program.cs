// See https://aka.ms/new-console-template for more information
using ConsoleApp.Implementations;
using ConsoleApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello ConsoleApp!");

IServiceCollection services = new ServiceCollection();

services.AddTransient<ITestService, MyTestService>();

IServiceProvider serviceProvider = services.BuildServiceProvider();

ITestService theService = serviceProvider.GetService<ITestService>();

if (theService == null)
{
    Console.WriteLine("test service is null!");
    return;
}

theService.PrintMessage();
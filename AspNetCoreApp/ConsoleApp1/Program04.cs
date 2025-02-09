using ConsoleApp1.ServiceImplements;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program04
    {
        public void Run()
        {
            Console.WriteLine("ASP NET CORE - ServiceCollection - 4");

            UseTransient();
            UseScoped();
            UseSingleton();
        }

        private void UseTransient()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddTransient<GuidService>();

            IServiceProvider provider = services.BuildServiceProvider();
            GuidService? guidService1 = provider.GetRequiredService<GuidService>();
            GuidService? guidService2 = provider.GetRequiredService<GuidService>();

            Console.WriteLine("UseTransient:");
            Console.WriteLine($"Guid1 = {guidService1.MyId}");
            Console.WriteLine($"Guid2 = {guidService2.MyId}");
        }

        private void UseScoped()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<GuidService>();

            IServiceProvider provider = services.BuildServiceProvider();

            var scope1 = provider.CreateScope();
            GuidService? guidService1A = scope1.ServiceProvider.GetRequiredService<GuidService>();
            GuidService? guidService1B = scope1.ServiceProvider.GetRequiredService<GuidService>();

            var scope2 = provider.CreateScope();
            GuidService? guidService2A = scope2.ServiceProvider.GetRequiredService<GuidService>();
            GuidService? guidService2B = scope2.ServiceProvider.GetRequiredService<GuidService>();

            Console.WriteLine("UseScoped:");
            Console.WriteLine($"scope1.Guid1A = {guidService1A.MyId}");
            Console.WriteLine($"scope1.Guid1B = {guidService1B.MyId}");
            Console.WriteLine($"scope2.Guid2A = {guidService2A.MyId}");
            Console.WriteLine($"scope2.Guid2B = {guidService2B.MyId}");
        }

        private void UseSingleton()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<GuidService>();

            IServiceProvider provider = services.BuildServiceProvider();

            GuidService? guidService0A = provider.GetRequiredService<GuidService>();
            GuidService? guidService0B = provider.GetRequiredService<GuidService>();

            var scope1 = provider.CreateScope();
            GuidService? guidService1A = scope1.ServiceProvider.GetRequiredService<GuidService>();
            GuidService? guidService1B = scope1.ServiceProvider.GetRequiredService<GuidService>();

            var scope2 = provider.CreateScope();
            GuidService? guidService2A = scope2.ServiceProvider.GetRequiredService<GuidService>();
            GuidService? guidService2B = scope2.ServiceProvider.GetRequiredService<GuidService>();

            Console.WriteLine("UseSingleton:");
            Console.WriteLine($"Guid0A        = {guidService0A.MyId}");
            Console.WriteLine($"Guid0B        = {guidService0B.MyId}");
            Console.WriteLine($"scope1.Guid1A = {guidService1A.MyId}");
            Console.WriteLine($"scope1.Guid1B = {guidService1B.MyId}");
            Console.WriteLine($"scope2.Guid2A = {guidService2A.MyId}");
            Console.WriteLine($"scope2.Guid2B = {guidService2B.MyId}");
        }
    }
}
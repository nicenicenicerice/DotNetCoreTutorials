using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Implementations
{
    internal class MyTestService : ITestService
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello my test service.");
        }
    }
}

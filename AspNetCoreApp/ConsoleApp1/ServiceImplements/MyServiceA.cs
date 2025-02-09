using ConsoleApp1.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ServiceImplements
{
    internal class MyServiceA : ITestService
    {
        public string GetMessage()
        {
            return "ITestService::MyServiceA";
        }
    }
}

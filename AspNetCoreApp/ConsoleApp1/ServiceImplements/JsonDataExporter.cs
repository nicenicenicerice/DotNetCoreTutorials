using ConsoleApp1.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ServiceImplements
{
    internal class JsonDataExporter : IDataExporter
    {
        public string Output(string content)
        {
            return $"JsonDataExporter: {content}";
        }
    }
}

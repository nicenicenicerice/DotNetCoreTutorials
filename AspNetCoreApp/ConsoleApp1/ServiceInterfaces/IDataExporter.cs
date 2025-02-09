using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ServiceInterfaces
{
    internal interface IDataExporter
    {
        public string Output(string content);
    }
}

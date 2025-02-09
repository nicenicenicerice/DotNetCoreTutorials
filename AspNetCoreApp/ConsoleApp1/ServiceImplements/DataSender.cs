using ConsoleApp1.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ServiceImplements
{
    internal class DataSender
    {
        private IDataExporter _dataExporter;

        public DataSender(IDataExporter dataExporter)
        {
            _dataExporter = dataExporter;
        }

        public void Send(string message)
        {
            Console.WriteLine(_dataExporter.Output(message));
        }
    }
}

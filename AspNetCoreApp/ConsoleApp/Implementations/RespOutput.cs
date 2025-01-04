using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Implementations
{
    public class RespOutput : IRespOutput
    {
        private IFormatWriter _formatWriter;

        public RespOutput(IFormatWriter formatWriter)
        {
            _formatWriter = formatWriter;
        }

        public void Output(string message)
        {
            string resp = _formatWriter.Write(message);
            Console.WriteLine($"Output => {resp}");
        }
    }
}

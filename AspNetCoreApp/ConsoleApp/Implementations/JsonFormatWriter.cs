using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Implementations
{
    public class JsonFormatWriter : IFormatWriter
    {
        string IFormatWriter.Write(string value)
        {
            return $"Json Format Writer: {value}";
        }
    }
}

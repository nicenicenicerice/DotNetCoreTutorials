using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp.Implementations
{
    public class XmlFormatWriter : IFormatWriter
    {
        string IFormatWriter.Write(string value)
        {
            return $"XML  Format Writer: {value}";
        }
    }
}

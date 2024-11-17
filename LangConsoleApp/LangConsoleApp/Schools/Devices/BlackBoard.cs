using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LangConsoleApp.Schools.Devices
{
    internal class BlackBoard
    {
        public int Width { get; set; } = 1024;

        public int Height { get; set; } = 768;

        public string GetDescription(string memo = "none")
        {
            return $"BlackBoard: Width = {Width}；Height = {Height}；Memo = {memo}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Machines
{
    internal partial class Engine
    {
        public string Code { get; set; } = "XXXX";

        public string Name { get; set; } = "RiceEngine";

        public Engine(string code, string name)
        {
            Code = code;
            Name = name;

            Init();
        }

        partial void Init();
    }
}

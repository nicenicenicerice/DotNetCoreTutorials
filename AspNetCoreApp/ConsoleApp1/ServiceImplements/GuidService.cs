using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ServiceImplements
{
    internal class GuidService
    {
        public GuidService()
        {
            MyId = Guid.NewGuid().ToString();
        }

        public string MyId { get; private set; }
    }
}

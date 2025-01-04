using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Configs
{
    internal class ReferenceKeyValuePair<TKey, TVal> where TVal : class
    {
        TKey Key { get; set; }
        TVal Val { get; set; }
    }
}

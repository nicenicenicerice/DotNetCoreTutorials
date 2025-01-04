using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Configs
{
    internal class KeyValuePair<TKey, TVal, TData>
    {
        public TKey Key { get; set; }

        public TVal Val { get; set; }

        public TData[] List = new TData[10];

        public void SetPair(TKey key, TVal val)
        {
            Key = key;
            Val = val;
        }

        public TVal GetVal()
        {
            return Val;
        }
    }
}

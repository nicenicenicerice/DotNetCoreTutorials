using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Delegates
{
    internal delegate void MyDelegate01(string msg);

    internal delegate string MyDelegate02();

    internal delegate T MyDelegate03<T>(T param1, T param2);
}

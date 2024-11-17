using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Storehouses
{
    internal class GreetingStore
    {
        private string[] _list = {
            "Hello world!",
            "I am Rice.",
            "I am very cool.",
            "Nice to meet you~",
        };

        public string this[int index]
        {
            get
            {
                return _list[index];
            }

            set
            {
                _list[index] = value;
            }
        }

        public int GetStoreSize()
        {
            return _list.Length;
        }
    }
}
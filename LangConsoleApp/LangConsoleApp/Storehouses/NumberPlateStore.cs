using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Storehouses
{
    internal class NumberPlateStore
    {
        private string[] _list = {
            "One",
            "Two",
            "Three",
        };

        public string this[int index]
        {
            get => _list[index];
            set => _list[index] = value;
        }

        public int this[string index]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(index))
                {
                    return -1;
                }

                string key = index.ToLower();

                for (int i = 0; i < _list.Length; i++)
                {
                    string val = _list[i].ToLower();
                    if (val == key)
                    {
                        return i;
                    }
                }

                return -1;
            }
        }
    }
}

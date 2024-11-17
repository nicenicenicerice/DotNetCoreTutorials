using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Storehouses
{
    internal class GenericDataStore<T>
    {
        private T[] _list = new T[10];

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _list.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _list[index];
            }

            set
            {
                if (index < 0 || index >= _list.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _list[index] = value;
            }
        }

        public int GetStoreSize()
        {
            return _list.Length;
        }
    }
}

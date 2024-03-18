using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyList<T>
    {
        T[] items;

        //constructor method
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[tempArray.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = item;

            }
            items[items.Length - 1] = item;
        }

        public int Length
        {
            get
            {
                return items.Length;
            }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}

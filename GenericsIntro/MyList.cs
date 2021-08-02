using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList() //constructor 
        {
            items = new T[0];
        }

        public void ADD(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
              
        }
    }
}

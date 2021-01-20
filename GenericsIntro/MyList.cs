using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        //classı new ler isem constructor otomatik çalışıyor.

        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //tempArray == geçici dizi
            T[] tempArray = items;
            items = new T[items.Length+1]; //dizinin eleman sayısını verir.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}

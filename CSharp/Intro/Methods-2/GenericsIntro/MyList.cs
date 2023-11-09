using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        private object get;

        //constructor
        public MyList()
        {
            items = new T[0]; // newlediğimiz anda çalışan yapıdıır.
        }
        public void Add(T item)
        {
            T[] tempArray = items; //geçici dizi;
            items = new T[items.Length+1]; //dizinin eleman sayısını 1 arttırır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //tempte geçici tuttuğumuz elemanları alıyoruz.
            }
            items[items.Length-1] = item; // eklenmek istenen elemanı şuan ekledik.
        }

        public int Lenght
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}

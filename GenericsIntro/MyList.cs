using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //Generic Class.List sınıfını kendimiz oluşturuyoruz. (List kullanımı Koleksiyonlar projesinde)
    {
        T[] items;
        public MyList()  //constructer metodu. Class ismi ile aynıdır. İlk çalışan metot. Program.cs'de "new MyList();" dendiği anda burası çalışır.
        {
            items = new T[0];  //eleman sayısı 0 olsun.
        }
        public void Add(T item) //Programcı hangi tip verirse 
        {
            T[] tempArray = items;  //geçici dizi oluşturduk. items referansını(adresini) tutması için.
            items = new T[items.Length+1]; //Eleman sayısını 1 arttır. (Burda yeni adres nolu boş bir dizi oluşur)

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //geçici olarak tuttuğumuz önceki elemanları items dizisine aktarıyoruz.
            }

            items[items.Length - 1] = item; // Add ile gelen elemanı ekle -> items'deki son index numarasına. (Örn: items.Length 6 ise son elemanın index nosu 5'tir. O yüzden Length-1 yazıyoruz.)
        }

        public int Length
        {
            get { return items.Length; } //eleman sayısını verir.
        }

        public T[] Items
        {
            get { return items; } //elemanları listeler.
        }
    }
}

using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, double, bool = değer tip -> değer tipler bellekte stack alanında tutulur.
            // array, class, interface = referans tip

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = 30 oldu

            int[] sayilar1 = new int[] { 10, 20, 30 }; //dizinin adı stack alanında, içindeki değerler heap alanında tutulur.
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;  //sayilar2'nin referans numarası sayilar1'e atandı. Yani artık ikisi de heap alanında aynı adrese gider.
            sayilar2[0] = 999;
            // sayilar1[0] = 999 oldu.

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //ürünle ilgili operasyonları içerir. Ekleme, silme, güncelleme gibi. CRUD (Create,Read,Update,Delete) işlemleri
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla(int sayi1, int sayi2) //int tipinde değer gönderir.
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2); 
        }

    }
}

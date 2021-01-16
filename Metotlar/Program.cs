using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metotlar tekrar tekrar kullanılabilirliği sağlar.

            Urun urun1 = new Urun();  //Class tanımlamak - Class'ın örneği oluşturmak - instance
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            // C# type safe - tip güvenli bir dildir.
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("--------Metotlar----------");
            //encapsulation - Kapsülleme ->  Örnek : Ekle2 metotu yerine Ekle metotunu kullanmamız.

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);


        }
    }
}


// Don't repeat yourself - DRY - Clean Code - Best Practice
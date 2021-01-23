using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) //Hangi krediyi gönderirsen o kredinin referansı çalışır. -Method injection
        {
            //Başvuran bilgilerini değerlendirme
          
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //Kaç tane girileceği belli değilse. Birden fazla kredinin hesabını yapmak istiyoruz.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}

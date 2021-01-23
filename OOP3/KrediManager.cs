using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    //interface isimlerinin başına I eklenir.
    //İçinde sadece imza metotları olur.
    interface IKrediManager //Tüm kredi tiplerinde olması gerekenler için bir şablon görevi görür.
    {
        void Hesapla();
        void BiseyYap();

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //İngilizcesi: Individial
    class GercekMusteri : Musteri  // Miras - inheritance   Gerçek müşteri bir müşteridir. 
    { //Burada sadece gerçek müşteri özellikleri yer alır.
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}

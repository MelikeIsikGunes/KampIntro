using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //İngilizcesi: Coorporate
    class TuzelMusteri :Musteri  // Miras - inheritance   Tüzel müşteri bir müşteridir. Ebeveyn:Musteri. Musteride olan her şey tüzel müşteride vardır.
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}

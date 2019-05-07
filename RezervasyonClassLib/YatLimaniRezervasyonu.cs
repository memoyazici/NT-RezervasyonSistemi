using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonClassLib
{
    public class YatLimaniRezervasyonu : Rezervasyon
    {
        protected override string KiralananYerTipi()
        {
            return "Yer";
        }
        public override string UygulamaAdi()
        {
            return "Yat Limani Rezervasyonu";
        }
        public override bool YanYanaIkiYerBirdenRezervasyonYapilabilirMi()
        {
            return true;
        }
        public override int Fiyat(int gun, bool ciftYer)
        {
            // gunluk 1000 TL. cift yer icin iki kati.
            return gun * 1000 * (ciftYer ? 2 : 1);
        }
        protected override bool ErtesiGunTemizlikIcinBosBirakilacakMi()
        {
            // Yat limani uygulamasinda temizlik icin ertesi gunun bos birakilmasina gerek yoktur.
            return false;
        }
    }
}

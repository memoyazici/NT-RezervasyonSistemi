using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonClassLib
{
    public class CadirRezervasyonu : Rezervasyon
    {
        protected override string KiralananYerTipi()
        {
            return "Yer";
        }
        public override string UygulamaAdi()
        {
            return "Cadir Yeri Rezervasyonu";
        }
        public override bool YanYanaIkiYerBirdenRezervasyonYapilabilirMi()
        {
            return true;
        }
        public override int Fiyat(int gun, bool ciftYer)
        {
            // kucuk cadir icin tek yer gunluk 100 TL. 
            // buyuk cadir icin cift yer gunluk 160 TL.
            return gun * (ciftYer ? 160 : 100);
        }
    }
}

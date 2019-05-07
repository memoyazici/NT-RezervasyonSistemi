using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonClassLib
{
    public class ButikOtelRezervasyonu : Rezervasyon
    {
        protected override string KiralananYerTipi()
        {
            return "Oda";
        }
        public override string UygulamaAdi()
        {
            return "Butik Otel Rezervasyonu";
        }
        public override bool YanYanaIkiYerBirdenRezervasyonYapilabilirMi()
        {
            return false;
        }
        public override int Fiyat(int gun, bool ciftYer)
        {
            // gunluk 100 TL, 5 gunden fazla ise gunluk 90 TL.
            return gun * (gun > 5 ? 90 : 100);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonClassLib
{
    public abstract class Rezervasyon
    {
        protected const int odaSayisi = 10;
        protected const int gunSayisi = 30;
        public enum RezervasyonEnum
        {
            Bos = 0,
            Dolu = 1,
            Temizlik = 2
        };
        public RezervasyonEnum[,] rezervasyonDurumu = new RezervasyonEnum[odaSayisi, gunSayisi];

        protected abstract string KiralananYerTipi();
        public abstract string UygulamaAdi();
        public abstract bool YanYanaIkiYerBirdenRezervasyonYapilabilirMi();
        public abstract int Fiyat(int gun, bool ciftYer);
        protected virtual bool ErtesiGunTemizlikIcinBosBirakilacakMi()
        {
            // Bu fonksiyonun default implementation'inda "temizlik icin ertesi gun bos birakilacak" olarak ayarlanir.
            return true;
        }

        public void RasgeleDoldur()
        {
            rezervasyonDurumu[0, 0] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[0, 1] = (ErtesiGunTemizlikIcinBosBirakilacakMi() ? RezervasyonEnum.Temizlik : RezervasyonEnum.Bos);
            rezervasyonDurumu[0, 5] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[0, 6] = (ErtesiGunTemizlikIcinBosBirakilacakMi() ? RezervasyonEnum.Temizlik : RezervasyonEnum.Bos);
            rezervasyonDurumu[1, 7] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[1, 8] = (ErtesiGunTemizlikIcinBosBirakilacakMi() ? RezervasyonEnum.Temizlik : RezervasyonEnum.Bos);
            rezervasyonDurumu[2, 9] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[2, 10] = (ErtesiGunTemizlikIcinBosBirakilacakMi() ? RezervasyonEnum.Temizlik : RezervasyonEnum.Bos);
            rezervasyonDurumu[5, 15] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[5, 16] = (ErtesiGunTemizlikIcinBosBirakilacakMi() ? RezervasyonEnum.Temizlik : RezervasyonEnum.Bos);
            rezervasyonDurumu[8, 20] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[8, 21] = (ErtesiGunTemizlikIcinBosBirakilacakMi() ? RezervasyonEnum.Temizlik : RezervasyonEnum.Bos);
            rezervasyonDurumu[0, 27] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[0, 28] = (ErtesiGunTemizlikIcinBosBirakilacakMi() ? RezervasyonEnum.Temizlik : RezervasyonEnum.Bos);
            rezervasyonDurumu[9, 29] = RezervasyonEnum.Dolu;

            rezervasyonDurumu[4, 0] = (ErtesiGunTemizlikIcinBosBirakilacakMi() ? RezervasyonEnum.Temizlik : RezervasyonEnum.Bos);
            rezervasyonDurumu[5, 1] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[5, 2] = (ErtesiGunTemizlikIcinBosBirakilacakMi() ? RezervasyonEnum.Temizlik : RezervasyonEnum.Bos);
        }
        public List<int> BugunkuBosOdalar()
        {

            List<int> odalar = new List<int>();
            bool bosOdaYok = true;
            for (int i = 0; i < odaSayisi; i++)
            {
                if (rezervasyonDurumu[i, 0] == RezervasyonEnum.Bos)
                {
                    if (ErtesiGunTemizlikIcinBosBirakilacakMi() == false
                        || rezervasyonDurumu[i, 1] == RezervasyonEnum.Bos)
                    {
                        // bos oda bulundu
                        bosOdaYok = false;
                        //Console.WriteLine(i + 1);
                        odalar.Add(i+1);
                    }
                }
            }
            if (bosOdaYok)
            {
                //Console.WriteLine("Bugun icin bos " + KiralananYerTipi().ToLower() + " yok");
                return odalar;
            }
            else
            {
                return odalar;
            }

           
        }
        static void TarihCetveliniYazdir(string onKisim)
        {
            Console.Write(onKisim);
            for (int j = 0; j < gunSayisi; j++)
            {
                Console.Write(" {0:00}", DateTime.Today.AddDays(j).Day);
            }
            Console.WriteLine();
        }
        public string[,] AylikDolulukDurumu()
        {
            //TarihCetveliniYazdir("      ");
            string[,] aylikListe = new string[odaSayisi,gunSayisi];

            for (int i = 0; i < odaSayisi; i++)
            {
                //Console.Write(KiralananYerTipi() + " {0:00}", i + 1); //Oda01, Oda02 satir basliklari icin
                for (int j = 0; j < gunSayisi; j++)
                {
                    if (rezervasyonDurumu[i, j] == RezervasyonEnum.Bos)
                        //Console.Write(" - ");
                        aylikListe[i, j] = " O ";
                    else if (rezervasyonDurumu[i, j] == RezervasyonEnum.Dolu)
                        //Console.Write(" D ");
                        aylikListe[i, j] = " D ";
                    else
                        //Console.Write(" x ");
                        aylikListe[i, j] = " X ";
                }
                //Console.WriteLine();
            }

            return aylikListe;
        }
        public int[] GunBazindaDolulukOranlari()
        {
            //TarihCetveliniYazdir(" -------- ");
            //Console.Write("Doluluk % ");
            int doluOdaSayisi = 0;
            int[] oranlar = new int[30];

            for (int j = 0; j < gunSayisi; j++)
            {
                doluOdaSayisi = 0;
                for (int i = 0; i < odaSayisi; i++)
                {
                    if (rezervasyonDurumu[i, j] == RezervasyonEnum.Dolu)
                    {
                        doluOdaSayisi++;
                    }
                }
                oranlar[j] = (int)100 * doluOdaSayisi / odaSayisi;
                //Console.Write("{0,3}", (int)(100f * doluOdaSayisi / odaSayisi));
            }
            //Console.WriteLine();
            return oranlar;
        }
        // bugun icin tek gunluk rezervasyon yapar
        public void RezervasyonYap(bool yanYanaIkiRezervasyon = false)
        {
            RezervasyonYap(DateTime.Today, DateTime.Today, yanYanaIkiRezervasyon);
        }
        // baslangic tarihinden itibaren verilen gun sayisi kadar rezervasyon yapar
        public void RezervasyonYap(DateTime basTarihi, int gun, bool yanYanaIkiRezervasyon = false)
        {
            RezervasyonYap(basTarihi, basTarihi.AddDays(gun), yanYanaIkiRezervasyon);
        }
        // verilen iki tarih arasinda rezervasyon yapar
        public void RezervasyonYap(DateTime date1, DateTime date2, bool yanYanaIkiRezervasyon = false)
        {
            if (yanYanaIkiRezervasyon == true && YanYanaIkiYerBirdenRezervasyonYapilabilirMi() == false)
            {
                Console.WriteLine("Ayni rezervasyonda yan yana iki yer ayrilmasina izin verilmiyor");
                return;
            }
            if (date1 < DateTime.Today)
            {
                Console.WriteLine("Baslangic tarihi bugunden kucuk olamaz");
                return;
            }
            if (date2 < date1)
            {
                Console.WriteLine("Bitis tarihi baslangic tarihinden kucuk olamaz");
                return;
            }
            if ((date1 - DateTime.Today).Days >= gunSayisi)
            {
                Console.WriteLine("Baslangic tarihi {0:dd/MM/yyyy} tarihinden buyuk olamaz", DateTime.Today.AddDays(gunSayisi - 1));
                return;
            }
            if ((date2 - DateTime.Today).Days >= gunSayisi)
            {
                Console.WriteLine("Bitis tarihi {0:dd/MM/yyyy} tarihinden buyuk olamaz", DateTime.Today.AddDays(gunSayisi - 1));
                return;
            }
            int gun1 = (date1 - DateTime.Today).Days;
            int gun2 = (date2 - DateTime.Today).Days;
            bool bosOdaYok = true;
            for (int i = 0; i < odaSayisi; i++)
            {
                // yerleri ikiser ikiser kontrol ederken, hep bir sonraki yere de bak.
                // son yerden bir onceki yere kadar devam et.
                if (yanYanaIkiRezervasyon && i == (odaSayisi - 1))
                    break;

                bool odaMusait = true;
                // yan yana iki yer isteniyorsa, ayni anda yandaki yeri de kontrol et.
                for (int k = 0; k <= (yanYanaIkiRezervasyon ? 1 : 0); k++)
                {
                    for (int j = gun1; j <= gun2; j++)
                    {
                        if (rezervasyonDurumu[i + k, j] != RezervasyonEnum.Bos)
                        {
                            odaMusait = false;
                            break;
                        }
                    }
                    // temizlik islemi icin bir sonraki gunun de bos olmasini kontrol et
                    if (ErtesiGunTemizlikIcinBosBirakilacakMi())
                    {
                        if (gun2 < (gunSayisi - 1))
                        {
                            if (rezervasyonDurumu[i + k, gun2 + 1] != RezervasyonEnum.Bos)
                                odaMusait = false;
                        }
                    }
                }
                if (odaMusait)
                {
                    bosOdaYok = false;
                    for (int j = gun1; j <= gun2; j++)
                    {
                        for (int k = 0; k <= (yanYanaIkiRezervasyon ? 1 : 0); k++) // sonraki yeri de rezerve et.
                            rezervasyonDurumu[i + k, j] = RezervasyonEnum.Dolu;
                    }
                    // bitis tarihi son gun degilse, sonraki gunu temizlik icin ayir
                    if (ErtesiGunTemizlikIcinBosBirakilacakMi())
                    {
                        if (gun2 < (gunSayisi - 1))
                        {
                            for (int k = 0; k <= (yanYanaIkiRezervasyon ? 1 : 0); k++) // sonraki yeri de rezerve et.
                                rezervasyonDurumu[i + k, gun2 + 1] = RezervasyonEnum.Temizlik;
                        }
                    }
                    Console.WriteLine("{0} "
                        + (yanYanaIkiRezervasyon ? "ve {1} " : "")
                        + "numarali " + KiralananYerTipi().ToLower() + " sizin icin ayrildi", i + 1, i + 2);
                    // Fiyat hesaplamasini goster
                    Console.WriteLine("Toplam fiyat : {1} TL, {0} gun.",
                        (date2 - date1).Days + 1,
                        this.Fiyat((date2 - date1).Days + 1, yanYanaIkiRezervasyon));
                    break;
                }
            }
            if (bosOdaYok)
                Console.WriteLine("Istediginiz tarihte bos " + KiralananYerTipi().ToLower() + " yok");
        }
        public void GunSonuIslemi()
        {
            for (int i = 0; i < odaSayisi; i++)
            {
                for (int j = 0; j < gunSayisi - 1; j++)
                {
                    rezervasyonDurumu[i, j] = rezervasyonDurumu[i, j + 1];
                }
                // son gun dolu ise gunleri kaydirdiktan sonra ertesi gunu temizlik icin ayir.
                if (rezervasyonDurumu[i, gunSayisi - 2] == RezervasyonEnum.Dolu
                    && ErtesiGunTemizlikIcinBosBirakilacakMi())
                    rezervasyonDurumu[i, gunSayisi - 1] = RezervasyonEnum.Temizlik;
                else
                    rezervasyonDurumu[i, gunSayisi - 1] = RezervasyonEnum.Bos;
            }
        }
    }
}

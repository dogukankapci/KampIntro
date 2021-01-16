using System;
using System.Collections.Generic;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0; // while döngüsünde kullanılacak.

            Urun urun1 = new Urun()
            {
                ID = 1,
                UrunAdi = "Laptop",
                UrunAciklamasi = "Günlük işleriniz için idealdir",
                Miktar = 5,
                UrunFiyati = 3500
            };

            Urun urun2 = new Urun()
            {
                ID = 2,
                UrunAdi = "Mouse",
                UrunAciklamasi = "Kablolu Mouse",
                Miktar = 20,
                UrunFiyati = 5
            };

            Urun urun3 = new Urun()
            {
                ID = 3,
                UrunAdi = "Klavye",
                UrunAciklamasi = "Oyuncuların vazgeçilmez oyun arkadaşı",
                Miktar = 14,
                UrunFiyati = 125
            };

            Urun[] urunler = new Urun[]
            {
                urun1,urun2,urun3
            };

            Console.WriteLine("Urun" + "\t\t" + "Fiyat" + "\t\t" + "Stok" + "\t\t" + "Açıklama\n");

            foreach (Urun urun in urunler)
            {
                Console.Write(urun.UrunAdi + "\t\t");
                Console.Write(urun.UrunFiyati + "\t\t");
                Console.Write(urun.Miktar + "\t\t");
                Console.WriteLine(urun.UrunAciklamasi);
            }

            Console.WriteLine();

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.Write(urunler[i].UrunAdi + "\t\t");
                Console.Write(urunler[i].UrunFiyati + "\t\t");
                Console.Write(urunler[i].Miktar + "\t\t");
                Console.WriteLine(urunler[i].UrunAciklamasi);
            }

            Console.WriteLine();

            while (sayac < urunler.Length)
            {
                Console.Write(urunler[sayac].UrunAdi + "\t\t");
                Console.Write(urunler[sayac].UrunFiyati + "\t\t");
                Console.Write(urunler[sayac].Miktar + "\t\t");
                Console.WriteLine(urunler[sayac].UrunAciklamasi);
                sayac++;
            }



        }

    }

    public class Urun
    {
        public int ID { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }
        public string UrunAciklamasi { get; set; }
        public int Miktar { get; set; }
    }


}
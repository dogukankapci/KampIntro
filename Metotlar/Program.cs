using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // aşağıdaki 3 bilgi ayrı ayrı bir ürünü tanımlamada yetersiz kalırlarken, class kullanımında bu problem ortadan kalkıyor.
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            // class kullanımı bilgilerimizi düzene sokuyor.
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            // Urun array'i oluşturma
            Urun[] urunler = new Urun[] { urun1, urun2 };  // bu veriler normalde bir veri kaynağından gelir.

            // type-safe -- tip güvenli : çalışacağım verinin tipini bilmek isterim diyor. C# böyle bir dildir. Type-safe'dir.
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("----------------Metotlar------------------");

            // instance - örnek
            //encapsulation - kapsülleme (ayrı ayrı yazacağın düzensiz yapıyı bir düzene sokma.)
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}



//Metotlar => tekrar tekrar kullanılabilirliği sağlar.
//Don't repeat yourself! - DRY - Clean Code - Best Practise (En iyi uygulama teknikleri)
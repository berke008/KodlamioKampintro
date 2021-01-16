using System;

namespace Methotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // bir class olduğu zaman onu newlemen gerekiyor
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.Id = 10000;

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Id = 10001;

            Product urun3 = new Product();
            urun3.Adi = "Çilek";
            urun3.Fiyati = 10;
            urun3.Aciklama = "Misss";
            urun3.Id = 10002;

            Product[] urunler = new Product[] {urun1, urun2, urun3 };

            //  veritipi - farketmez - in - list ismi (type-safe)
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");

            }

            Console.WriteLine("---------------Metotlar---------------");
            // instance - örnek
            // encaspulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);


            sepetManager.Ekle2("Armut", "yeşil armut", 12, 8);
            sepetManager.Ekle2("Havuç", "yeşil Havuç", 2, 10);
            sepetManager.Ekle2("Ayva", "yeşil Ayva", 21, 88);

        }
    }
}


// Dont repeat yourself - DRY - Clean Code - Best Practice
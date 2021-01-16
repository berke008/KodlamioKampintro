using System;
using System.Collections.Generic;
using System.Text;

namespace Methotlar
{
    class SepetManager
    {
        // naming convention
        //syntax
        public void Ekle(Product urun)             // fonksiyon & parametre
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urun.Adi); 
        }
        
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urunAdi);
        }
    }
}

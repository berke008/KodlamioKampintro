using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Berke";
            int age = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Berke";
            kurs1.izlenme = "88";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.izlenme = "55";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Engin";
            kurs3.izlenme = "sekiz";

            //Console.WriteLine(kurs1.KursAdi + ": " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen);
            }

           // Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public string izlenme { get; set; }
    }
}

using System;

namespace DegerVeReferansTipler
    // int, decimal, double, float, bool(0-1) = değer tip --> stack belleğinde depolanır
    // array, class, interface = referans --> heap belleğinde depolanır
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEĞER
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            //REFERANS
            int[] sayilar1 = new int[] {10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

        }
    }
}

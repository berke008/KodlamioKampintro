using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Java";
            string kurs2 = "Python";
            string kurs3 = "C#";
           
            // array - dizi

            string[] kurslar = new string[] {"Java", "Python", "#C" };

            //  (başlangıç; -e kadar; birer arttır)
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            // foreach dizilere uygulanır - (kurslar bir dizi/array)
            // dizileri daha rahat dolaşmak için foreach kullanırız.
            foreach (string kurs in kurslar)
            {
                // yukarıda kurs yerine ne yazarsan parantez için o.
                Console.WriteLine(kurs);
            }
        }
    }
}

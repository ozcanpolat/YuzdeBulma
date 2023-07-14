using System;

namespace YuzdeBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi, yuzde, sonuc;
            Console.Write("Sayıyı Girin : ");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yüzdeyi Girin : ");
            yuzde = Convert.ToDouble(Console.ReadLine());
            sonuc = sayi * yuzde / 100;
            Console.WriteLine("Girilen sayının % {0}' i : {1}", yuzde, sonuc);
            Console.ReadKey();
        }
    }
}

using System;

namespace CampIntro
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            // type safety = tip güvenliği
            // "" arasına string yazılır, '' arasına Python'daki gibi string yazılmaz char'lar yazılabilir.

            // Değer tutucu, alias -> Değişken
            string kategoriEtiketi = "Kategoriler";
            // int - tam sayılar büyüklük sınırı vardır
            int ogrenciSayisi = 32000;
            // double - ondalıkı sayılar için kullanılır.
            double faizOrani = 1.45;
            // boolean veri tipi true-false
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                // Azalma
                Console.WriteLine("Azalış oku");
            }
            else if (dolarDun < dolarBugun)
            {
                // Artma
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Düz çizgi");
            }
            


            // DO NOT REPEAT YOURSELF - DRY 


        }
    }
}
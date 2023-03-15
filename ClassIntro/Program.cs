using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args) 
        {
            string adi = "Özgür";
            int yas = 25;

            Kurs kurs1 = new Kurs(); // Class'dan bir instance bu şekilde yaratılır. Array yaratmaya benzerdir.
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 67;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Özgür Özcan";
            kurs2.IzlenmeOrani = 33;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Berkay";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 25;
            // Yukarıdaki örnekleri e-ticaret sitelerindeki ürün kartlarına benzetebiliriz.

            //Console.WriteLine(kurs1.KursAdi+" : "+kurs1.Egitmen);

            // Class/DataType[] arrayName = new Class/DataType[] {} -> Array tanımlama
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };
            
            //       var -> Böyle verildiğinde iterasyon yapılan array'deki elemanın veri tipi neyse onu otomatik alır.
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.Egitmen);
                Console.WriteLine(kurs.IzlenmeOrani);
                Console.WriteLine("-----------------");
            }

        }
    }

    class Kurs
    {
        // property - özellik - nesne özelliği (attribute)
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
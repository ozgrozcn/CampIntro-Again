using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            Product urun2 = new Product();
            Product urun3 = new Product();

            urun1.Name = "Elma";
            urun1.Price = 15;
            urun1.Description = "Amasya elması";

            urun2.Name = "Çilek";
            urun2.Price = 34;
            urun2.Description = "Bal gibi çilek";

            urun3.Name = "Karpuz";
            urun3.Price = 55;
            urun3.Description = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] {urun1, urun2, urun3 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Description);
                Console.WriteLine(urun.Price);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("-------------Metotlar------------");
            SepetManager sepetManager = new SepetManager();
            // reusibility 
            sepetManager.Add(urun1);
            sepetManager.Add(urun2);
            sepetManager.Add(urun3);

            sepetManager.Add2("Elma", "Mükemmel elma");
            sepetManager.Add2("Armut", "Yeşil armut");


        }
    }
}

// Metotlar, tekrar tekrar kullanılabilir kod parçalarını tekrara düşmeden kullanabilmemizi sağlar

// DON'T REPEAT YOURSELF - DRY
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        // naming convention - Metotlar PascalCase
        // parametre fonksiyon tanımlanırken verilen dışarıdan alınan argümana karşılık gelen değişken.
        public void Add(Product urun) // void metot - değer döndürmeyen fonksiyon
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : {0}",urun.Name);
        }


        /* Bu şekilde tanımlandığında metoda yeni bir parametre eklenirse kullanıldığı yerlerde patlayacaktır.
         Bunun yerine yukarıdaki örnekte olduğu gibi bu özellikleri de barındıran bir object göndermemiz 
         daha iyi olur. Buna encapsullation denir, nesnenin tüm özellikleri metoda bir paket halinde yollanır.
        */
        public void Add2(string urunAdi, string aciklama, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : {0}", urunAdi);
        }
    }
}

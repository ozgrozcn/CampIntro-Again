using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java kursu";

            // Array - Dizi
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya Başlangıç İçin Temel Kurs", "Java kursu","Python Kursu", "C++" };
           
            // Döngü, iterasyon yapmak için bazı adımları sırayla yapmak için kullanılır.
            // for (başlangıç değeri; sağlanacak koşul; artış/azalış)
            for (int i=0; i < kurslar.Length; i++) // array.Length -> Array uzunluğunu döner Python'da len() gibi.
            {
                // Array indexleri 0'dan başlar.
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Sayfa Sonu");

            // foreach (dataType alias in array)
            foreach (string kurs in kurslar)
            {
                // Genelde sektörde dizileri kolay dolaşmak için kullanılır.
                // Classlar büyük harfle başlar string tanımlanırken String olarak da yazılabilir ama C#'da yazım kuralıdır.
                Console.WriteLine(kurs);
            }
        }
    } 

}

/* == Eşit mi? Eşit ise 1
 * != Eşit değil mi? Eşit değil ise 1
 * A < B Küçüktür A B'den küçükse 1
 * A > B Büyüktür A B'den büyükse 1
 * A <= B Küçük eşittir A B'ye eşitse ya da küçükse 1
 * A >= B Büyük eşittir A B'ye eşitse ya da büyükse 1
 * ! Değildir.
 * && Ve
 * || Veya 
 */
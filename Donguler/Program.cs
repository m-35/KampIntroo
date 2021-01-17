using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            //Arraylerde yani dizilerde tutarız
            //donguleri elimizdeki veriyi dönmeleri için kullanıyoruz.
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs",
                "Java","Pyhton","C#"};
            //Lenght eleman sayısı
            //for genel amaçlar için kullanırız.
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            //dizi temelli yapıları tek tek dönmeye yarıyor==foreach dizilere uygulanır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}


using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama!!!
            //kategoriEtiketi değer tutucu alias takam isim

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45; //Ondalıklı sayıları tuttuğumuz yer
            bool sistemeGirisYapmisMi = true; //gerçek hayatta bu kısım veri kaynağından gelir
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonunu göster");
            }
            else
            {
                Console.WriteLine("Eşittir butonunu göster");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
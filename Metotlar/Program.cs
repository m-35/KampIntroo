using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); //class ın örneği denir.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya";
            urun1.StokAdedi = 10;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 5;


            Urun[] urunler = new Urun[] { urun1, urun2 };
            //type safe -- tip güvenli çalışcağım veri tipini bilmeliyim foreach kısmındaki ilk yazdığımız Urun.
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("--------------Metotlar-----------------");
            //instance - örnek
            //encapsulation -- kapsülleme düzensiz olacak yapıyı düzene sokuyosun!

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
        }
    }
}

//tekrar tekrar kullanılabilirliği sağlar metotlar.-clean code - best practice
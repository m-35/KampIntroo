using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax -- yazım şekilleri
        public void Ekle(Urun urun) //() normal parantez görürsek orada metot çalışıyor. () içine tanımladığım parametre
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        }
    }
}
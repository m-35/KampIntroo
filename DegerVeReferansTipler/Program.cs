using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1?? 30

            int[] sayilar = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar = sayilar2; //sayiların referans numarası sayilar2 nin referans numarasına (adresine) atanıyor.
            sayilar2[0] = 999;
            // sayilar[0] ? 999
            //int decimal float double bool(0-1 tutar) === değer tip  
            //array class interface === referans tip
            //bellekte iki tip yerimiz var stack ve heap
            //stack = değer tipler burda tanımlanıyor. 
            //stack == sayilar  heap = new dediğim anda gelip heapte alan oluşturur 10, 20 , 30 (adres değeri tutuyor.) new ==bellekte yeni bir adres oluştur.


        }
    }
}

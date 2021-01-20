using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet ( karenin altında üç nokta varsa tab tab yaptığımız)
    class Product 
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //referans anahtarı
        public string ProductName { get; set; } 
        public double UnitPrace { get; set; } //Ürünün birim fiyatı
        public int UnitsInStock { get; set; } //Stok Adedi
        //bu tip classlarda sadece özellik olur.
        //CRUD == CREATE READ UPDATE DELETE

    }
}

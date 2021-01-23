using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            İndividualCustomer customer1 = new İndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.TcNo = "12345678910";


            CorporateCustomers customer2 = new CorporateCustomers();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri birbirlerinin yerine kullanılamaz.İkiside müşteri ama farklı tipte müşteriler.
            //SOLID 


            Customer customer3 = new İndividualCustomer();//bellekteki bir referans numarasıdır.
            Customer customer4 = new CorporateCustomers();
            //Müşteri class ı hem gerçek müşterinin hemde tüzel müşterinin referansını tutabiliyor.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}

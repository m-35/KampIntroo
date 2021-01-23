using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ArtisanLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf Kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}

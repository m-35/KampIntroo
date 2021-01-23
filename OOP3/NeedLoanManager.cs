using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NeedLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}

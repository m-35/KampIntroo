using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface lerin birbirlerinin alternatifi olan kod içeriklerinin farklı olan kod içerikleri için kullanırız.
            ICreditManager needLoanManager = new NeedLoanManager();
            ICreditManager vehicleLoanManager = new VehicleLoanManager();      
            ICreditManager mortgageLoanManager = new MortgageLoanManager();
            ICreditManager artisanLoanManager = new ArtisanLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() {databaseLoggerService, smsLoggerService};

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(needLoanManager,loggers); //Hangi class ı gönderirsem onun methodu çalışır.
            applicationManager.MakeAnApplication(artisanLoanManager,loggers);

            List<ICreditManager> credits = new List<ICreditManager>() {needLoanManager , vehicleLoanManager, mortgageLoanManager };
            
                //applicationManager.MakeCreditPreNotification(credits);
             
           
        }
    }
}

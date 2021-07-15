using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
        static void Main(string[] args)
        {
            ICreditManager financeCreditManager = new FinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager morgateCreditManager = new MorgateCreditManager();
            
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();

            ApplicationManager applicationManager= new ApplicationManager();
            applicationManager.MakeAnApplication(financeCreditManager, new List<ILoggerService> {dataBaseLoggerService,fileLoggerService,new SmsLoggerService() }) ;
            Console.WriteLine("---------------------ikinci yöntem---------------------------");
            List<ILoggerService> loggers = new List<ILoggerService> { new DataBaseLoggerService(),new FileLoggerService(),new SmsLoggerService() };
            applicationManager.MakeAnApplication(morgateCreditManager,loggers);
            Console.WriteLine("---------------------ödeme planları--------------------------");
            List<ICreditManager> credits = new List<ICreditManager>() {financeCreditManager,vehicleCreditManager,morgateCreditManager};
            applicationManager.MakeACreditPreliminaryİnformation(credits);

            
        
        }
    }
}

using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager  mortgageCreditManager = new MortgageCreditManager();

            ILoggerService dataBaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();
           
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(new TradesmanCreditManager(), new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()});

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager,transportCreditManager};

            //applicationManager.GiveCreditPreliminaryInformation(credits);
        }
    }
}

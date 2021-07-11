using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.MusteriNo = "31231231";
            customer1.Adi = "Umut";
            customer1.Soyadi = "Uçar";
            customer1.TcNo = "12313213232";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.MusteriNo = "231412412";
            customer2.SirketAdi = "Kodlama.io";
            customer2.VergiNo = "23231231";



            Customer customer3 = new IndividualCustomer(); 
            Customer customer4 = new CoorporateCustomer();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}

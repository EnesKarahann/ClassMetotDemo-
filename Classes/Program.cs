using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //MÜŞTERİ TANIMLAMA VE EKLEME
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Enes";
            customer1.CustomerSurname = "Karahan";
            customer1.CustomerJob = "Engineer";

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Can";
            customer2.CustomerSurname = "Karahan";
            customer2.CustomerJob = "Architect";
            

            
            Customer[] Customers = new Customer[] {customer1,customer2 };

            foreach (var customer in Customers)
            {
                Console.WriteLine(customer.CustomerId+" "+customer.CustomerName+customer.CustomerSurname+" "+customer.CustomerJob);
            }

            Console.WriteLine("-------METOTLAR-------");

            //Müşteri ekleme ve silme
            CustomerManager customermanager = new CustomerManager();
            customermanager.MusteriEkle(customer1);
            customermanager.MusteriEkle(customer2);

            customermanager.MusteriSil(customer1);









        }
    }
}

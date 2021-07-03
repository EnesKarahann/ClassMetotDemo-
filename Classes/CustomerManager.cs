using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        

        Customer customer = new Customer();
        public void MusteriEkle(Customer customer)
        {
            
            Console.WriteLine("Bankamıza hoşgeldiniz."+customer.CustomerName);

        }
        public void MusteriSil(Customer customer)
        {
            Console.WriteLine("Hayatta başarılar. "+customer.CustomerName);
        }
        

    }
}

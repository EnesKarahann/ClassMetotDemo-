using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestServer
{
    class Odev2
    {
        int number1 = 20;
        int result = Ekle(3, 5);
        Console.WriteLine(result);
        static int Ekle(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
    
}

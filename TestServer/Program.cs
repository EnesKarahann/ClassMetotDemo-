using System;

namespace TestServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Add();
            Add();
            Add();
            var result=Add2(3,5);
            var result2 = Add2();
            Console.WriteLine(result+"   "+result2);

            int number1 = 20;
            int number2 = 100;
            var result3 = Add3(out number1, number2);
            Console.WriteLine(result3);
            Console.WriteLine(number1);

            int result4 = Multiply(2,4,6);
            Console.WriteLine(result4);
            
            Console.WriteLine(Add4(2,3,4,5,6));

            




            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!!!");
        }
        static int Add2(int number1=5,int number2=30)//Default değerlerini atadım.
        {
            int result = number1 + number2;
            return result;
        }
        static int Add3(out int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(int number,params int[] numbers)
        {
            return numbers.Sum();
        }

        

       
            
            




    }
}

using System;
using System.Collections;
namespace VietTutsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Cac so nguyen to nho hon 100 la: \n");
            for (i = 0; i < 100; i++)
            {
                if (isPrimeNumber(i))
                {
                    Console.Write("{0} ", i);
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }


   
        static Boolean isPrimeNumber(int n)
        {
            // so nguyen n < 2 khong phai la so nguyen to
            if (n < 2)
            {
                return false;
            }
            // check so nguyen to khi n >= 2
            int squareRoot = (int)Math.Sqrt(n);
            int i;
            for (i = 2; i <= squareRoot; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
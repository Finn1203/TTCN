using System;
namespace VietTutsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, i;
            // in ra man hinh cac so thuan nghich co 6 chu so
            for (i = 100000; i < 1000000; i++)
            {
                if (isThuanNghich(i))
                {
                    Console.Write("{0}\n", i);
                    count++;
                }
            }
            Console.Write("Tong cac so thuan nghich co 6 chu so la: {0}", count);

            Console.WriteLine();
            Console.ReadKey();
        }

        /**
         * kiem tra so thuan nghich
         * 
         * @param n: so nguyen duong
         * @return 1: la so thuan nghich
         *         0: khong la so thuan nghich
         */
        static Boolean isThuanNghich(int n)
        {
            int[] a = new int[20];
            int dem = 0, i;
            int DEC_10 = 10;
            // phan tich n thanh mang cac chu so
            do
            {
                a[dem++] = (n % DEC_10);
                n = n / DEC_10;
            } while (n > 0);
            // kiem tra tinh thuan nghich
            for (i = 0; i < (dem / 2); i++)
            {
                if (a[i] != a[(dem - i - 1)])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
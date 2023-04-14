using System;
namespace VietTutsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so nguyen duong n = ");
            n = int.Parse(Console.ReadLine());
            // phan tich so nguyen duong n
            phanTichSoNguyen(n);

            Console.WriteLine();
            Console.ReadKey();
        }

        /**
       * Phan tich so nguyen n thanh tich cac thua so nguyen to
       */
        static void phanTichSoNguyen(int n)
        {
            int i = 2;
            int dem = 0;
            int[] a = new int[100];
            int originalN = n;
            // phan tich
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    a[dem++] = i;
                }
                else
                {
                    i++;
                }
            }
            // neu dem = 0 thi n la nguyen to
            if (dem == 0)
            {
                a[dem++] = n;
            }
            // in ket qua ra man hinh
            Console.Write("{0} = ", originalN);
            for (i = 0; i < dem - 1; i++)
            {
                Console.Write("{0} x ", a[i]);
            }
            Console.Write("{0}", a[dem - 1]);
        }
    }
}
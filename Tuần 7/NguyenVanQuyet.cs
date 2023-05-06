using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, count = 0;
            Console.WriteLine("NHAP SO GIOI HAN : ");
            m = int.Parse(Console.ReadLine());
            int[] a = new int[m];
            Console.WriteLine("NHAP NHIEU SO VAO :");
            for (int i = 0; i < m; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int o in a)
            {
                if (o == 1)
                {
                    count++;
                }
            }
            Console.WriteLine("SO MOT XUAT HIEN TONG CONG LA: ");
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
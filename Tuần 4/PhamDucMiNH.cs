using System;
using System.Collections;
namespace VietTutsCsharp
{
    class Program
    {
        public static int CHAR_55 = 55;
        public static int CHAR_48 = 48;

        static void Main(string[] args)
        {
            int n = 14;
            Console.Write("So {0} trong he co so 2 = ", n);
            convertNumber(n, 2);
            Console.Write("\nSo {0} trong he co so 16 = ", n);
            convertNumber(n, 16);

            Console.WriteLine();
            Console.ReadKey();
        }


        /**
         * chuyen doi so nguyen n sang he co so b
         * 
         * @author viettuts.vn
         * @param n: so nguyen
         * @param b: he co so
         */
        static int convertNumber(int n, int b)
        {
            if (n < 0 || b < 2 || b > 16)
            {
                Console.Write("He co so hoac gia tri chuyen doi khong hop le!");
                return 0;
            }
            int i;
            char[] arr = new char[20];
            int count = 0;
            int m;
            int remainder = n;
            while (remainder > 0)
            {
                if (b > 10)
                {
                    m = remainder % b;
                    if (m >= 10)
                    {
                        arr[count] = (char)(m + CHAR_55);
                        count++;
                    }
                    else
                    {
                        arr[count] = (char)(m + CHAR_48);
                        count++;
                    }
                }
                else
                {
                    arr[count] = (char)((remainder % b) + CHAR_48);
                    count++;
                }
                remainder = remainder / b;
            }
            // hien thi he co so
            for (i = count - 1; i >= 0; i--)
            {
                Console.Write("{0}", arr[i]);
            }
            return 1;
        }
    }
}
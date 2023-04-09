using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "apple", "banana", "orange", "pear", "kiwi" };

            Array.Sort(myArray);

            foreach (string fruit in myArray)
            {
                Console.WriteLine(fruit);
            }

            Array.Reverse(myArray);

            foreach (string fruit in myArray)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}

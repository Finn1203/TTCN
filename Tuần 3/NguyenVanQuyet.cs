using System;

class Program {
    static void Main(string[] args) {
        int[] numbers = { 2, 4, 6, 8, 10 };

        Console.WriteLine("The original array:");
        PrintArray(numbers);

        // using the Array.Reverse() method to reverse the array
        Array.Reverse(numbers);
        Console.WriteLine("\nThe reversed array:");
        PrintArray(numbers);

        // using the Array.IndexOf() method to find the index of an element
        int index = Array.IndexOf(numbers, 6);
        Console.WriteLine("\nThe index of 6 in the array is: " + index);

        // using the Array.Sort() method to sort the array
        Array.Sort(numbers);
        Console.WriteLine("\nThe sorted array:");
        PrintArray(numbers);

        // using the Array.BinarySearch() method to search for an element
        int value = 8;
        index = Array.BinarySearch(numbers, value);
        if (index >= 0) {
            Console.WriteLine("\n" + value + " found at index " + index);
        } else {
            Console.WriteLine("\n" + value + " not found in the array");
        }
    }

    static void PrintArray(int[] arr) {
        foreach (int i in arr) {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

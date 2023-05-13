using System;

class TowerOfHanoi
{
    static void Main(string[] args)
    {
        int n = 3; // Số đĩa
        int from = 1, to = 3, temp = 2; // Số cột

        Move(n, from, to, temp);
    }

    static void Move(int n, int from, int to, int temp)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from column {from} to column {to}");
            return;
        }

        Move(n - 1, from, temp, to);
        Console.WriteLine($"Move disk {n} from column {from} to column {to}");
        Move(n - 1, temp, to, from);
    }
}


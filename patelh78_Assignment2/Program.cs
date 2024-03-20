using System;

class Program
{
    static void Main()
    {
        int EvenNum = 0;
        int OddNum = 0;

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is even number.");
                EvenNum += i;
            }
            else
            {
                Console.WriteLine($"{i} is odd number.");
                OddNum  += i;
            }
        }

        Console.WriteLine($"Total of even numbers: {EvenNum}");
        Console.WriteLine($"Total of odd numbers: {OddNum}");
    }
}

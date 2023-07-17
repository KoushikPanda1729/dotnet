using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the starting range :");
        int starting = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the ending range :");
        int ending = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = starting; i <= ending; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Sum of natural number is {sum}");

    }
}
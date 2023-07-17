using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Prime numbers in the array:");
        foreach (var number in numbers)
        {
            if (IsPrime(number))
            {
                Console.Write(number + " ");
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}

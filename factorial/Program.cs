using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number to get factorial :");
        int number = int.Parse(Console.ReadLine());

        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"Factorial of {number} is {factorial}");
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number 1 ");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number 2 ");
        int number2 = int.Parse(Console.ReadLine());

        number1 = number1 + number2;
        number2 = number1 - number2;
        number1 = number1 - number2;

        Console.WriteLine($"After swap number1 is {number1} and number2 is {number2}");
    }
}
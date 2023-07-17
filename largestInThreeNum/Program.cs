using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number1");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number2");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number3");
        int number3 = int.Parse(Console.ReadLine());


        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine($"{number1} is the largest number");
        }
        else if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine($"{number2} is the largest number");
        }
        else
        {
            Console.WriteLine($"{number3} is the largest number");
        }
    }
}
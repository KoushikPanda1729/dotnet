using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the temperature in Celcius ");
        int celcius = int.Parse(Console.ReadLine());

        int resultCelcius = (celcius * 9 / 5) + 32;
        Console.WriteLine($" Fahrenheit temperature is {resultCelcius}");
    }
}
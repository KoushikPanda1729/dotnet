using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size ");
        int size = int.Parse(Console.ReadLine());


        int[] array = new int[size];

        Console.WriteLine("Enter the Elements ");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the target ");
        int searchValue = int.Parse(Console.ReadLine());



        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == searchValue)
            {
                index = i;
            }
        }
        if (index == 0)
        {
            Console.WriteLine($"The target {searchValue} is not exist");
        }
        else
        {
            Console.WriteLine($"The target {searchValue} is found in {index} index ");
        }


    }
}
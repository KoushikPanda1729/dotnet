using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of array ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Enter the elements");

        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }


        // selection sort 

        for (int i = 0; i < size; i++)
        {
            int pointer = i;
            for (int j = i + 1; j < size; j++)
            {
                if (array[pointer] > array[j])
                {
                    pointer = j;
                }
                if (pointer != i)
                {
                    int temp = array[pointer];
                    array[pointer] = array[i];
                    array[i] = temp;
                }
            }
        }

        Console.WriteLine("The sorted array is ");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }


    }
}
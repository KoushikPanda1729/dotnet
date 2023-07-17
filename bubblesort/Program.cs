using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of array ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Enter the elements");

        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        // bubble sort 

        for (int i = 0; i < size - 1; i++)
        {
            for (int j = 0; j < size - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("sorted array is ");

       foreach (var item in array)
       {
        Console.WriteLine(item);
       }
    }
}
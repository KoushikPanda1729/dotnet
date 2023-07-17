using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size ");
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the search element ");
        int searchElement = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Enter the elements ");

        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

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

        Console.WriteLine("Sorted array is ");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(array[i]);
        }

        int index = binary(array, searchElement);

        if (index!=-1)
        {
            Console.WriteLine($"Element {searchElement} found at index {index}");
        }
        else
        {
            Console.WriteLine($"Element {searchElement} not found in array");
        }



    }

    static int binary(int[] arr, int target)
    {
        int low = 1;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return -1;
    }
}
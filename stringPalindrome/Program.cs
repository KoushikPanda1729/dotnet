using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string");
        string input = Console.ReadLine();

        if (isPalindrome(input))
        {
            Console.WriteLine("The string is palindrome");
        }
        else
        {
            Console.WriteLine("The string is not palindrome");
        }
    }

    static bool isPalindrome(string str)
    {
        str = str.ToLower();
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
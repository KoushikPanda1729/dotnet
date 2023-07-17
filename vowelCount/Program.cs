using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the string");
        string inputVowel = Console.ReadLine();

        int vowelCount = countVowelFunction(inputVowel);

        Console.WriteLine($"Number of vowels in the input string: {vowelCount}");
    
    }


    static int countVowelFunction(string str)
    {
        int count = 0;
        foreach (char countItem in str)
        {
            if (isVowel(countItem))
            {
                count++;
            }
        }
        return count;
    }

    static bool isVowel(char vowel)
    {
        char lowerItem = Char.ToLower(vowel);
        return lowerItem == 'a' || lowerItem == 'e' || lowerItem == 'i' || lowerItem == 'o' || lowerItem == 'u';
    }
}
using System;

namespace Home_work
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            Console.WriteLine("Enter a substring to search for:");
            string substring = Console.ReadLine();

            int count = CountSubstringOccurrences(sentence, substring);

            Console.WriteLine($"Number of occurrences of '{substring}' in the sentence: {count}");
        }

        static int CountSubstringOccurrences(string sentence, string substring)
        {
            int count = 0;
            int index = 0;
            while ((index = sentence.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }
            return count;
        }
    }
}
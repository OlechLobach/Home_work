using System;

namespace Home_work
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();

            Console.WriteLine("Enter the forbidden word:");
            string forbiddenWord = Console.ReadLine();

            int replacementsCount = 0;
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(forbiddenWord, StringComparison.OrdinalIgnoreCase))
                {
                    words[i] = new string('*', words[i].Length);
                    replacementsCount++;
                }
            }

            string result = string.Join(" ", words);

            Console.WriteLine("Result:");
            Console.WriteLine(result);
            Console.WriteLine($"Statistics: {replacementsCount} replacements of the word \"{forbiddenWord}\".");
        }
    }
}
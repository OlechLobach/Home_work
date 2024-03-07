using System;

namespace Home_work
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            int vowelCount = CountVowels(sentence);

            Console.WriteLine($"Number of vowels in the sentence: {vowelCount}");
        }

        static int CountVowels(string sentence)
        {
            int count = 0;
            foreach (char c in sentence)
            {
                if (IsVowel(c))
                {
                    count++;
                }
            }
            return count;
        }

        static bool IsVowel(char c)
        {
            c = char.ToLower(c);
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}
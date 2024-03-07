using System;

namespace Home_work
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            // Split the sentence into words based on spaces
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Count the number of words
            int wordCount = words.Length;

            Console.WriteLine($"The sentence contains {wordCount} {(wordCount == 1 ? "word" : "words")}.");
        }
    }
}
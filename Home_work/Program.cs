using System;

namespace Home_work
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string reversedSentence = ReverseWordsInSentence(words);

            Console.WriteLine("Reversed sentence:");
            Console.WriteLine(reversedSentence);
        }

        static string ReverseWord(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static string ReverseWordsInSentence(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseWord(words[i]);
            }
            return string.Join(" ", words);
        }
    }
}
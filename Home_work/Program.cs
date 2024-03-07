using System;

namespace Home_work

{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string to encrypt:");
            string input = Console.ReadLine();

            Console.WriteLine("Enter the shift amount (a positive integer):");
            int shift;
            while (!int.TryParse(Console.ReadLine(), out shift) || shift < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
            }

            string encryptedText = Encrypt(input, shift);
            Console.WriteLine($"Encrypted string: {encryptedText}");
        }

        static string Encrypt(string input, int shift)
        {
            string result = "";
            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    result += (char)(((ch + shift - offset) % 26) + offset);
                }
                else
                {
                    result += ch;
                }
            }
            return result;
        }
    }
}
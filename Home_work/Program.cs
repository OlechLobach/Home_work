using System;

namespace Home_work
{


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine();

            string result = CapitalizeFirstLetter(text);

            Console.WriteLine("Result:");
            Console.WriteLine(result);
        }

        static string CapitalizeFirstLetter(string text)
        {
            char[] chars = text.ToCharArray();
            bool capitalizeNext = true;

            for (int i = 0; i < chars.Length; i++)
            {
                if (capitalizeNext && char.IsLetter(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);
                    capitalizeNext = false;
                }
                else if (chars[i] == '.' || chars[i] == '!' || chars[i] == '?')
                {
                    capitalizeNext = true;
                }
            }

            return new string(chars);
        }
    }
}
using System;

namespace Home_work

{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an arithmetic expression using only + and - operators:");
            string input = Console.ReadLine();

            
            input = input.Replace(" ", "");

           
            int result = 0;
            int currentNumber = 0;

            char operation = '+';

           
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    currentNumber = currentNumber * 10 + (c - '0');
                }
 
                else
                {
                    if (operation == '+')
                    {
                        result += currentNumber;
                    }
                    else if (operation == '-')
                    {
                        result -= currentNumber;
                    }

                    operation = c;
                    currentNumber = 0;
                }
            }

            if (operation == '+')
            {
                result += currentNumber;
            }
            else if (operation == '-')
            {
                result -= currentNumber;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
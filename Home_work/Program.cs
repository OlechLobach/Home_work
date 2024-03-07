using System;

namespace Home_work
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int[] array = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }

            Console.Write("Enter a parameter to compare with: ");
            int parameter = int.Parse(Console.ReadLine());

            int count = CountValuesLessThanParameter(array, parameter);

            Console.WriteLine("Number of values less than " + parameter + ": " + count);
        }

        static int CountValuesLessThanParameter(int[] arr, int parameter)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num < parameter)
                    count++;
            }
            return count;
        }
    }
}
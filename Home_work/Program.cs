using System;

namespace Home_work
{
    class Program
    {
        static void Main()
        {
            int rows, cols;
            Console.WriteLine("Enter the number of rows in the array:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns in the array:");
            cols = int.Parse(Console.ReadLine());

            int[,] array = new int[rows, cols];
            Console.WriteLine($"Enter {rows * cols} integers separated by spaces:");

            string[] input = Console.ReadLine().Split(' ');
            if (input.Length != rows * cols)
            {
                Console.WriteLine("Incorrect number of elements!");
                return;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = int.Parse(input[i * cols + j]);
                }
            }

            int min = array[0, 0];
            int max = array[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }

            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");
        }
    }
}
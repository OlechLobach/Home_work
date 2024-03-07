using System;

namespace Home_work
{
    class Program
    {
        static void Main()
        {
            int[,] array = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-100, 101);
                }
            }

            Console.WriteLine("Array:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int min = array[0, 0];
            int max = array[0, 0];
            int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minRow = i;
                        minCol = j;
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            int sum = 0;
            int startRow = Math.Min(minRow, maxRow) + 1;
            int endRow = Math.Max(minRow, maxRow);
            int startCol = Math.Min(minCol, maxCol) + 1;
            int endCol = Math.Max(minCol, maxCol);
            for (int i = startRow; i < endRow; i++)
            {
                for (int j = startCol; j < endCol; j++)
                {
                    sum += array[i, j];
                }
            }

            Console.WriteLine($"\nSum of elements between min and max: {sum}");
        }
    }
}
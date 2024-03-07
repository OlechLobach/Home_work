using System;

namespace Home_work
{
    class Program
    {
        static void Main()
        {
            int[] A = new int[5];
            double[,] B = new double[3, 4];

            Console.WriteLine("Enter 5 integers separated by spaces:");
            string[] inputA = Console.ReadLine().Split(' ');
            for (int i = 0; i < 5; i++)
            {
                A[i] = int.Parse(inputA[i]);
            }

            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = random.NextDouble() * 100; 
                }
            }

            Console.WriteLine("Array A:");
            foreach (var item in A)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nArray B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }

            int maxA = A[0];
            int minA = A[0];
            int sumA = 0;
            int productA = 1;
            foreach (var item in A)
            {
                if (item > maxA) maxA = item;
                if (item < minA) minA = item;
                sumA += item;
                productA *= item;
            }

            double maxB = B[0, 0];
            double minB = B[0, 0];
            double sumB = 0;
            foreach (var item in B)
            {
                if (item > maxB) maxB = item;
                if (item < minB) minB = item;
                sumB += item;
            }

            int sumEvenA = 0;
            foreach (var item in A)
            {
                if (item % 2 == 0) sumEvenA += item;
            }

            double sumOddColumnsB = 0;
            for (int j = 1; j < 4; j += 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    sumOddColumnsB += B[i, j];
                }
            }

            Console.WriteLine("\nResults:");
            Console.WriteLine($"Max element in array A: {maxA}");
            Console.WriteLine($"Min element in array A: {minA}");
            Console.WriteLine($"Sum of elements in array A: {sumA}");
            Console.WriteLine($"Product of elements in array A: {productA}");
            Console.WriteLine($"Max element in array B: {maxB}");
            Console.WriteLine($"Min element in array B: {minB}");
            Console.WriteLine($"Sum of elements in array B: {sumB}");
            Console.WriteLine($"Sum of even elements in array A: {sumEvenA}");
            Console.WriteLine($"Sum of elements in odd columns of array B: {sumOddColumnsB}");
        }
    }
}
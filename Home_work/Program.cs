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

            int evenCount = 0;
            int oddCount = 0;
            int uniqueCount = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            uniqueCount = CountUniqueElements(array);

            Console.WriteLine("Number of even elements: " + evenCount);
            Console.WriteLine("Number of odd elements: " + oddCount);
            Console.WriteLine("Number of unique elements: " + uniqueCount);
        }

        static int CountUniqueElements(int[] arr)
        {
            int uniqueCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                    uniqueCount++;
            }
            return uniqueCount;
        }
    }
}
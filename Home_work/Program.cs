using System;

namespace Home_work
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the first array (M):");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of the second array (N):");
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[m];
            int[] array2 = new int[n];

            Console.WriteLine("Enter elements of the first array separated by spaces:");
            string input1 = Console.ReadLine();
            string[] elements1 = input1.Split(' ');
            for (int i = 0; i < m; i++)
            {
                array1[i] = int.Parse(elements1[i]);
            }

            Console.WriteLine("Enter elements of the second array separated by spaces:");
            string input2 = Console.ReadLine();
            string[] elements2 = input2.Split(' ');
            for (int i = 0; i < n; i++)
            {
                array2[i] = int.Parse(elements2[i]);
            }

            int[] result = FindCommonElementsWithoutDuplicates(array1, array2);

            Console.WriteLine("Common elements without duplicates:");
            foreach (int element in result)
            {
                Console.Write(element + " ");
            }
        }

        static int[] FindCommonElementsWithoutDuplicates(int[] arr1, int[] arr2)
        {
            int[] commonElements = new int[arr1.Length]; 
            int index = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                       
                        bool isDuplicate = false;
                        for (int k = 0; k < index; k++)
                        {
                            if (commonElements[k] == arr1[i])
                            {
                                isDuplicate = true;
                                break;
                            }
                        }

                      
                        if (!isDuplicate)
                        {
                            commonElements[index] = arr1[i];
                            index++;
                        }
                        break; 
                    }
                }
            }

       
            Array.Resize(ref commonElements, index);
            return commonElements;
        }
    }
}
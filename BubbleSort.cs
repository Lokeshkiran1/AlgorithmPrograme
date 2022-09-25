using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograme
{
    internal class BubbleSort
    {
        public static void BubbleSortIntegers()
        {
            int temp;
            int[] array = new int[5];
            Console.WriteLine("enter the five array integers");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i <= array.Length - 2; i++)
            {
                for (int j = 0; j < array.Length - (i + 1); j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array is:");
            foreach (int sorted in array)
            {
                Console.WriteLine(sorted + " ");
            }
        }
    }
}

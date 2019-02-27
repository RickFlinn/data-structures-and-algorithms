using System;
using System.Collections.Generic;

namespace Insertion_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] toSort = new int[] { 1, 4, 6, 2, 0 };
            int[] sorted = InsertionSort(toSort);
            foreach(int val in sorted)
            {
                Console.Write(val + " ");
            }
        }

        
        /// <summary>
        ///     Sorts an array of integers from small to large, and returns the array.
        /// </summary>
        /// <param name="array"> Array to sort </param>
        /// <returns> Sorted array </returns>
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;
                while (j > -1 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            return array;
        }

        
        /// <summary>
        ///     Generalized insertion sort that accepts an array and a delegate that provides logic to determine how two elements should be sorted.
        ///     Returns an array sorted using that logic.
        /// </summary>
        /// <param name="array"> Array to sort </param>
        /// <param name="sorter"> Ordering function </param>
        /// <returns> Sorted array </returns>
        public static object[] InsertionSort(object[] array, Func<object, object, bool> sorter)
        {
            for (int i = 1; i < array.Length; i++)
            {
                object temp = array[i];
                int j = i - 1;
                while (j > -1 && sorter(array[j], temp))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            return array;
        }
    }
}

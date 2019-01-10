using System;

namespace ArrayBinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1,2,3,4],4 returns " + BinarySearch(new int[] { 1, 2, 3, 4 }, 4));
            Console.WriteLine("[3,5,6],4 returns " + BinarySearch(new int[] { 3, 5, 6 }, 4));
            Console.WriteLine("[1, 2, 3, 4], 1 returns " + BinarySearch(new int[] { 1, 2, 3, 4 }, 1));
            Console.WriteLine("[1, 2, 3, 4], 2 returns " + BinarySearch(new int[] { 1, 2, 3, 4 }, 2));
            Console.WriteLine("[1, 2, 3, 4], 3 returns " + BinarySearch(new int[] { 1, 2, 3, 4 }, 3));
            Console.WriteLine("[1, 2, 3, 4, 5], 3 returns " + BinarySearch(new int[] { 1, 2, 3, 4, 5 }, 3));
            Console.WriteLine("[1, 2, 3, 4, 5], 4 returns " + BinarySearch(new int[] { 1, 2, 3, 4, 5 }, 4));
        }

        // Takes in a sorted array and a search key. If the search key exists within the given array,
        //  this method will return the index at which it occurs. If it does not, this method will return -1.
        public static int BinarySearch(int[] arr1, int num)
        {
            int start = 0;
            int end = arr1.Length - 1;
            int mid = arr1.Length / 2;

            // Prevents us from searching the array if given key exists outside on the ends of or outside of the given array
            if (num >= arr1[end] || num <= arr1[start])
            {
                if (arr1[end] == num)
                {
                    return end;
                } else if (arr1[0] == num)
                {
                    return 0;
                } else
                {
                    return -1;
                }
            }
            // Deals with edge cases where the given integer exists at start or end of given array
            

            while (mid != start) // stops the while loop when there are only two indexes within the search bounds, i.e. the search key was not found.
            {
                
                if (arr1[mid] == num)
                {
                    return mid;
                } else
                {
                    if (arr1[mid] > num)
                    {
                        end = mid;
                    } else if (arr1[mid] < num)
                    {
                        start = mid;
                    } 
                    mid = (start + end) / 2;
                }
            }
            return -1; // Returns -1 if the while loop is exited without finding the search key
        }
    }
}

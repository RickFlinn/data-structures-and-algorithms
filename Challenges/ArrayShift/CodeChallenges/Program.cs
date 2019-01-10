using System;

namespace CodeChallenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array1 = { 1, 2, 4, 5 };
            int[] array2 = { 2, 4, 6, 10, 12};
            int[] array3 = { 3, 6, 9, 15, 18, 21 };
            ArrayShift(array1, 3);
            ArrayShift(array2, 8);
            ArrayShift(array3, 12);
        }
        

        // Takes in an array of integers and a single integer as parameters, then creates and returns a new array consisting of the values 
        //  from the first array, with the given integer inserted in the middle.
        public static int[] ArrayShift(int[] arr1, int num1)
        {
            int[] arr2 = new int[arr1.Length + 1];

            for (int i = 0; i <= arr1.Length / 2; i++)
            {
                arr2[i] = arr1[i];
            }

            for (int i = arr2.Length - 1; i > arr2.Length/2; i--)
            {
                arr2[i] = arr1[i - 1];
            }

            
            arr2[arr2.Length / 2] = num1;
            

            IntArrayPrint(arr1);
            IntArrayPrint(arr2);

            return arr2;
        }

        public static void IntArrayPrint(int[] intArray)
        {
            string toPrint = $"{{ {intArray[0]}";
            for (int i = 1; i < intArray.Length; i++)
            {
                toPrint += $", {intArray[i]}";
            }
            toPrint += " }";
            Console.WriteLine(toPrint);
        }
    }
}

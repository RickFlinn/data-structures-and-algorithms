using System;
using LinkedListChallenge;
using LinkedListChallenge.Classes;

namespace KthFromEndChallenge
{
    public static class KthFromEndExtension
    {

        static void Main(string[] args)
        {
            LinkedList nuList = new LinkedList();
            int[] arr1 = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            foreach (int val in arr1)
            {
                nuList.Insert(val);
            }

            int[] kVals = { 4, 5, 1, 8, 0, 9, -1, 10, 11 };

            foreach (int val in kVals)
            {
                try
                {
                    nuList.GetKthFromEnd(val);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            nuList.GetMiddleNodeValue();
            
        }


        public static int GetKthFromEnd(this LinkedList list, int k)
        {
            try
            {
                if (k < 0)
                {
                    throw new ArgumentOutOfRangeException("value of k cannot be negative");
                }
                list.Current = list.Head;
                int listLength = 0;
                while (list.Current != null)
                {
                    list.Current = list.Current.Next;
                    listLength++;
                }
                Console.WriteLine($"Length is {listLength}");
                list.Current = list.Head;
                if (listLength < k)
                {
                    throw new ArgumentOutOfRangeException("value of k is greater than length of list");
                }
                for (int i = 1; i < listLength - k; i++)
                {
                    list.Current = list.Current.Next;
                }
                Console.WriteLine($"value {k}th from end of the list is {list.Current.IntVal}");
                return list.Current.IntVal;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        // NO UNIT TESTS BUILT - NOT INCLUDED


        //public static int GetMiddleNodeValue(this LinkedList list)
        //{
        //    try
        //    { 
        //        if (list.Head == null)
        //        {
        //            throw new Exception("Sorry, there are no nodes in this list!");
        //        }
        //        list.Current = list.Head;
        //        int listLength = 0;
        //        while (list.Current != null)
        //        {
        //            list.Current = list.Current.Next;
        //            listLength++;
        //        }
        //        list.Current = list.Head;
                
        //        for (int i = 0; i < listLength / 2; i++)
        //        {
        //            list.Current = list.Current.Next;
        //        }
        //        Console.WriteLine($"Value in middle of list is {list.Current.IntVal}");
        //        return list.Current.IntVal;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}
    }
}


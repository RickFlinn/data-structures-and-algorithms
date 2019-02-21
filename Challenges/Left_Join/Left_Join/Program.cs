using HashTables;
using System;
using System.Collections.Generic;

namespace Left_Join
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        ///     Takes in two HashTables and perform a "Left Join" - ALl key-value pairs from the Left table are returned, with the values of any matching
        ///       keys in the Right table appended. 
        ///     I.e., each key-value pair in the left hashtable is added into the first two indexes of an array;
        ///         then, the key is used to retrieve a value from the right HashTable if it exists, and added to the third index of the array.
        ///     Each of these arrays is added to a List as they are created; when all values in the Left Hashtable have been traversed,
        ///     this List is returned. 
        /// </summary>
        /// <param name="left"> Left HashTable </param>
        /// <param name="right"> Right HashTable </param>
        /// <returns> List of all left-joined keys and values </returns>
        public static List<object[]> LeftJoin(HashTable left, HashTable right)
        {
            if(left == null || right == null)
            {
                throw new ArgumentNullException("Cannot join null tables");
            }


            List<object[]> list = new List<object[]>();
            foreach(List<KeyValuePair<string, object>> bucket in left.BackingArray)
            {
                if(bucket != null)
                {
                    foreach(KeyValuePair<string, object> kvp in bucket)
                    {
                        object[] array = new object[3];
                        array[0] = kvp.Key;
                        array[1] = kvp.Value;
                        array[2] = right.Get(kvp.Key);
                        list.Add(array);
                    }
                }
            }
            return list;
        }

    }
}

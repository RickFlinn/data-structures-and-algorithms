using System;
using System.Collections.Generic;

namespace HashTables
{
    public class HashTable
    {
        public List<KeyValuePair<string, object>>[] BackingArray { get; set;}


        public HashTable()
        {
            BackingArray = new List<KeyValuePair<string, object>>[1024];
        }
        
        /// <summary>
        ///     Takes in a string key, and generates an index in the HashTable where that key-value pair will be located.
        /// </summary>
        /// <param name="key"> String key to hash </param>
        /// <returns> Hashed index as an integer </returns>
        public int Hash(string key)
        {
            int sum = 0;
            foreach(char c in key)
            {
                sum += c;
            }
            sum *= 677;
            return sum % 1024;
        }
        /// <summary>
        ///     Takes in a string key, and a value. If the given key doesn't already exist in the HashTable,
        ///   the given key is hashed into an iteger, and it and its and value are stored as a key-value pair
        ///   in the bucket at the hashed index.
        ///     Throws if the given Key already exists in this HashTable.
        /// </summary>
        /// <param name="key"> Key to store </param>
        /// <param name="value"> Object to store associated with given Key </param>
        
        public void Add(string key, object value)
        {
            if (Contains(key))
                throw new ArgumentOutOfRangeException($"The key \"{key}\" already exists in this HashTable.");

            KeyValuePair<string, object> kvp = new KeyValuePair<string, object>(key, value);

            int index = Hash(key);

            if (BackingArray[index] == null)
                BackingArray[index] = new List<KeyValuePair<string, object>>();

            BackingArray[index].Add(kvp);
        }

        /// <summary>
        ///      Gets the value associated with the given key in the HashTable, or null if the given key doesn't exist.
        /// </summary>
        /// <param name="key"></param>
        /// <returns> Value associated with given key </returns>
        public object Get(string key)
        {
            int index = Hash(key);
            if (BackingArray[index] == null)
                return null;


            foreach (KeyValuePair<string, object> k in BackingArray[index])
            {
                if (k.Key == key)
                {
                    return k.Value;
                }
            }
            return null;
        }



        /// <summary>
        ///  Returns whether the given key already exists within the HashTable
        /// </summary>
        /// <param name="key"></param>
        /// <returns> Whether given key already exists within the HashTable </returns>
        public bool Contains(string key)
        {
            int index = Hash(key);
            if (BackingArray[index] == null)
                return false;

            foreach (KeyValuePair<string, object> k in BackingArray[index])
            {
                if (k.Key == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

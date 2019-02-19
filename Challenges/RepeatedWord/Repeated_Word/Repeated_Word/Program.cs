using HashTables;
using System;

namespace Repeated_Word
{
    public class Program
    {
        static void Main(string[] args)
        {
            string ex = "The quick brown fox jumped over the";
            Console.WriteLine(RepeatedWord(ex) ?? "nuffin");
        }
        
        /// <summary>
        ///     Takes in an input string, and returns the first repeated word in the string.
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns> First repeated word </returns>
        public static string RepeatedWord(string inputString)
        {
            string temp = "";
            HashTable cashTable = new HashTable();
            int i = 0;
            while (i < inputString.Length)
            {
                while (i < inputString.Length && (inputString[i] > 'z' || inputString[i] < 'A' || (inputString[i] > 'Z' && inputString[i] < 'a')))
                {
                    i++;
                }
                while (i < inputString.Length && ((inputString[i] <= 'z' && inputString[i] >= 'a') || (inputString[i] <= 'Z' && inputString[i] >= 'A')))
                {
                    temp += inputString[i];
                    i++;
                }
                if (cashTable.Contains(temp))
                {
                    return temp;
                } else
                {
                    if (temp.Length > 0)
                        cashTable.Add(temp.ToLower(), 1);
                    temp = "";
                }
                if (i == inputString.Length)
                {
                    i++;
                }
            }
            return null;
        }
    }
}

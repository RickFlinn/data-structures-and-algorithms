using System;
using System.Collections;
using System.Collections.Generic;

namespace GenBalancedParenCombos
{
    public class Program
    {
        static void Main(string[] args)
        {

            PrintArrayValues(GenBalancedParenCombos(1));
            PrintArrayValues(GenBalancedParenCombos(2));
            PrintArrayValues(GenBalancedParenCombos(3));
            PrintArrayValues(GenBalancedParenCombos(4));

            PrintArrayValues(GenBalancedOptimal(3));
        }
        
        /// <summary>
        ///     Takes in an integer n, and returns an array of all permutations of code-legal bracket pairings for 
        ///      n pairs of parentheses.
        /// </summary>
        /// <param name="n"> Number of bracket pairs </param>
        /// <returns> Array of all possible bracket pair permutations with n pairs of brackets </returns>
        public static string[] GenBalancedParenCombos(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("Git outta here with that");
            }
            List<string> list = new List<string>();
            ParenGenHelper("", n, 0, list);
            return list.ToArray();
        }

        /// <summary>
        ///     Recursive helper function for GenBalancedParenCombos. Takes in a string, 
        /// </summary>
        /// <param name="str"> String to build upon </param>
        /// <param name="opensLeft"> Number of opening brackets left to place </param>
        /// <param name="closedsLeft"> Number of closing brackets that may legally be placed </param>
        /// <param name="list"> List to which a completed sets of parentheses pairs will be added to </param>
        private static void ParenGenHelper(string str, int opensLeft, int closedsLeft, List<string> list)
        {
            if (opensLeft <= 0 && closedsLeft > 0)
            {
                for (int i = 0; i < closedsLeft; i++)
                {
                    str += ")";
                }
                list.Add(str);

            } else
            {
                if (opensLeft > 0)
                {
                    ParenGenHelper(str + "(", opensLeft - 1, closedsLeft + 1, list);
                }
                if (closedsLeft > 0)
                {
                    ParenGenHelper(str + ")", opensLeft, closedsLeft - 1, list);
                }
            }
        }



        public static string[] GenBalancedOptimal(int n)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("()");
            while (q.Peek().Length < n * 2)
            {
                string partial = q.Dequeue();
                q.Enqueue("()" + partial);
                q.Enqueue(partial + "()");
                q.Enqueue("(" + partial + ")");
            }
            return q.ToArray();
        }



        // Prints all the values in an array of strings to the console. 
        public static void PrintArrayValues(string[] array)
        {
            foreach(string str in array)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
    }
}

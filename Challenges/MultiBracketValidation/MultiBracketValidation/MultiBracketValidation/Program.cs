using System;
using MultiBracketValidation.Classes;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] exampleInputs =
            {
                "{}",
                "{}(){}",
                "()[[Extra Characters]]",
                "(){}[[]]",
                "{}{Code}[Fellows](())",
                "[({}]",
                "([(",
                "{(})"
            };

            foreach(string s in exampleInputs)
            {
                Console.WriteLine($"Input {s} returns {MultiBracketValidation(s)}");
            }
        }
        
        /// <summary>
        ///     Takes in a string, and returns a boolean indicating whether the given string
        ///     contains valid code bracket pairs, or false if it contains invalid/unpaired brackets.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> Boolean indicating if given string has valid bracket pairs </returns>
        public static bool MultiBracketValidation(string input)
        {
            CharStack stack = new CharStack();
            foreach(char c in input)
            {
                if (c == '[' || c == '(' || c == '{')
                {
                    stack.Push(new CharNode(c));
                } else if (c == ']')
                {
                    if (stack.Peek() == null || stack.Pop().Value != '[')
                    {
                        return false;
                    }
                } else if (c == ')')
                {
                    if (stack.Peek() == null || stack.Pop().Value != '(')
                    {
                        return false;
                    }
                } else if (c == '}')
                {
                    if (stack.Peek() == null || stack.Pop().Value != '{')
                    {
                        return false;
                    }
                }
            }
            if (stack.Peek() != null)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}

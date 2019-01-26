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

using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.Classes
{
    public class CharNode
    {
        public CharNode Next { get; set; }
        public char Value { get; set; }

        public CharNode(char val)
        {
            Value = val;
        }

        public CharNode(char val, CharNode next)
        {
            Value = val;
            Next = next;
        }
    }
}

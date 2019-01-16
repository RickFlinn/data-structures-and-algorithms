using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListChallenge.Classes
{
    public class Node
    {
        public int IntVal { get; set; }
        public Node Next { get; set; }

        public Node (int value)
        {
            IntVal = value;
        }

        public Node (int value, Node next)
        {
            IntVal = value;
            Next = next;
        }
    }
}

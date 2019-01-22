using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    // Nodes contain a single integer value and a reference to the next Node in the data structure, if applicable.
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }


        public Node(int val)
        {
            Value = val;
        }

        public Node(int val, Node next)
        {
            Value = val;
            Next = next;
        }
    }

    
}

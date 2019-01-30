using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    // Nodes contain a single integer value and a reference to the next Node in the data structure, if applicable.
    public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }


        public Node(object val)
        {
            Value = val;
        }

        public Node(object val, Node next)
        {
            Value = val;
            Next = next;
        }
    }

    
}

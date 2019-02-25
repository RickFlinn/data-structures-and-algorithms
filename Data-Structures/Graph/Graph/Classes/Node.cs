using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Node
    {
        public object Value { get; set; }
        public List<Tuple<Node, int?>> Adjacencies { get; set; }


        // Instantiates a new Node with the given value.
        public Node(object value)
        {
            Value = value;
            Adjacencies = new List<Tuple<Node, int?>>();
        }

        

    }
}

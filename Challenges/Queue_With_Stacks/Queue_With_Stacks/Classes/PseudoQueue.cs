using System;
using System.Text;
using StacksAndQueues.Classes;

namespace Queue_With_Stacks.Classes
{

    // This class mimics the behavior of the Queue class by using two 
    //  Stack objects. 
    // The first Stack object is our "MainStack". 
    public class PseudoQueue
    {

        public Stack In { get; set; } // "Incoming" stack - values Enqueued to Top
        public Stack Out { get; set; } // "Outgoing" stack - values Dequeued from Top

        // Instantiates a new PsuedoQueue
        public PseudoQueue()
        {
            In = new Stack();
            Out = new Stack();
        }
        
        // Returns the node at the "Front" - the value peeked from our Out stack.
        public Node Peek()
        {
            FillOutIfEmpty();
            return Out.Peek();
        }

        // Removes and returns the Node at the top of our "Outgoing" stack.
        //  If there are no Nodes in the Out stack, move all the values in 
        //  our In stack to our Out stack.
        public Node Dequeue()
        {
            FillOutIfEmpty();
            return Out.Pop();
        }

        // Pushes a node to our Out stack.
        public void Enqueue(Node node)
        {
            In.Push(node);
        }

        // Checks the Out Stack to see if it is empty.
        //  If it is, move all Nodes in the In Stack to the Out Stack.
        private void FillOutIfEmpty()
        {
            if (Out.Peek() == null)
            {
                while (In.Peek() != null)
                {
                    Out.Push(In.Pop());
                }
            }
        }
        
    }
}

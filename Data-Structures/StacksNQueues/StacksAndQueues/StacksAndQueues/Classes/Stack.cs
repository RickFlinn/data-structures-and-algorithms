using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    // Data structure that consists of linked Nodes. Nodes may only be added, viewed, and removed from the top of the Stack.
    //  
    public class Stack
    {
        public Node Top { get; set; }

        // Takes in a new Node and places it on top of the stack, resetting the value of Top to the new Node.
        public void Push(Node node)
        {
            if (Top == null)
            {
                Top = node;
            } else
            {
                node.Next = Top;
                Top = node;
            }
        }

        // Removes and returns the Node on top of the stack, resetting the value of Top to the next Node on the stack.
        // Returns null if there is no Node on the stack.
        public Node Pop()
        {
            Node popped = null;
            try
            {
                if (Top != null)
                {
                    popped = Top;
                    Top = Top.Next;
                    popped.Next = null;
                }
                else
                {
                    throw new NullReferenceException();
                }
            } catch (NullReferenceException)
            {
                Console.WriteLine("There are no Nodes in this Stack.");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return popped;
        }

        // Returns the Node currently on top of the stack.
        public Node Peek()
        {
            return Top;
        }
    }
}

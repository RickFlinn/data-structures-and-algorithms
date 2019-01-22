using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    // Queues are a data structure consisting of Nodes, where new Nodes can only be removed from the Front, 
    //  and Nodes can only be added to the end - like a Queue for a concert, those who enter first leave first, and 
    //  Those who enter last are removed last
    public class Queue
    {
        public Node Front { get; set; }
        public Node End { get; set; }

        // Takes in a Node and adds it to the end of the Queue.
        //  If the Queue is empty, this Node becomes the new Front and End point for the Queue as its sole member.
        public void Enqueue(Node node)
        {
            if (Front == null)
            {
                Front = node;
                End = node;
            } else
            {
                End.Next = node;
                End = node;
            }
        }

        // Removes and returns the Node at the front of the Queue.
        //  If there are no Nodes in the Queue, throws a NullReferenceException. 
        public Node Dequeue()
        {
            Node dqueued = null;
            try
            {
                if (Front != null)
                {
                    dqueued = Front;
                    Front = Front.Next;
                    dqueued.Next = null;
                }
                else
                {
                    throw new NullReferenceException();
                }
            } catch (NullReferenceException)
            {
                Console.WriteLine("There are no Nodes in this Queue.");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return dqueued;
        }

        // Returns the Node at the front of the Queue. 
        public Node Peek()
        {
            return Front;
        }
    }
}

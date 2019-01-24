using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Shelter_Challenge.Classes
{
    // CageQueues are a data structure consisting of CageNodes, where new CageNodes can only be removed from the Front, 
    //  and CageNodes can only be added to the end - like a Queue for a concert, those who enter first leave first, and 
    //  Those who enter last are removed last
    public class CageQueue
    {
        public CageNode Front { get; set; }
        public CageNode End { get; set; }

        // Takes in a CageNode and adds it to the end of the Queue.
        //  If the Queue is empty, this CageNode becomes the new Front and End point for the Queue as its sole member.
        public void Enqueue(CageNode cageNode)
        {
            if (Front == null)
            {
                Front = cageNode;
                End = cageNode;
            }
            else
            {
                End.Next = cageNode;
                End = cageNode;
            }
        }

        // Removes and returns the CageNode at the front of the Queue.
        //  If there are no CageNodes in the Queue, throws a NullReferenceException. 
        public CageNode Dequeue()
        {
            CageNode dqueued = null;
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
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("There are no CageNodes in this Queue.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return dqueued;
        }

        // Returns the CageNode at the front of the Queue. 
        public CageNode Peek()
        {
            return Front;
        }
    }
}

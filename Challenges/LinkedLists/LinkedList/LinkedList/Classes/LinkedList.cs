using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListChallenge.Classes
{
    public class LinkedList
    {

        public Node Head { get; set; }
        public Node Current { get; set; }

        public void Insert(int val)
        {
            try
            {
                Node node = new Node();
                node.IntVal = val;
                if (Head == null)
                {
                    Head = node;
                    Current = Head;
                }
                else
                {
                    Current = Head;
                    Head = node;
                    Head.Next = Current;
                    ResetCurrent();
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool Includes (int value)
        {
            try
            {
                while (Current != null)
                {
                    if (Current.IntVal == value)
                    {
                        ResetCurrent();
                        return true;
                    }
                    Current = Current.Next;
                }
                
                
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            ResetCurrent();
            return false;
        }

        public void PrintListValues()
        {
            try
            { 
                int counter = 1;
                while (Current != null)
                {
                    Console.WriteLine($"Node {counter} contains value {Current.IntVal}");
                    counter++;
                    Current = Current.Next;
                }
                ResetCurrent();
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void ResetCurrent()
        {
            try
            {
            Current = Head;
            } catch (Exception e)
            {
                Console.WriteLine("Error resetting current to head");
                Console.WriteLine(e.Message);
            }
        }
    }
}

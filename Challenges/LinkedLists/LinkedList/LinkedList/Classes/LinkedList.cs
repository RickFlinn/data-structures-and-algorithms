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
                Current = Head;
                while (Current != null)
                {
                    if (Current.IntVal == value)
                    {
                        return true;
                    }
                    Current = Current.Next;
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public void PrintListValues()
        {
            try
            {
                Current = Head;
                int counter = 1;
                while (Current != null)
                {
                    Console.WriteLine($"Node {counter} contains value {Current.IntVal}");
                    counter++;
                    Current = Current.Next;
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public void Append(int value)
        {
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Node nuNode = new Node();
            nuNode.IntVal = value;
            Current.Next = nuNode;
        }

        public void InsertBefore(int value, int nuValue)
        {
            try
            {
                Current = Head;
                if (Current.IntVal == value)
                {
                    Insert(nuValue);
                }
                else
                {
                    while (Current.Next.IntVal != value && Current.Next != null)
                    {
                        Current = Current.Next;
                    }
                    if (Current.Next == null)
                    {
                        throw new ArgumentOutOfRangeException("Given search key does not exist in this list");
                    }
                    Node nuNode = new Node();
                    nuNode.IntVal = nuValue;
                    nuNode.Next = Current.Next;
                    Current.Next = nuNode;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void InsertAfter(int value, int nuValue)
        {
            try
            {
                Current = Head;
                if (Current.IntVal == value)
                {
                    Insert(nuValue);
                }
                else
                {
                    while (Current.IntVal != value && Current.Next != null)
                    {
                        Current = Current.Next;
                    }
                    if (Current.Next == null && Current.IntVal != value)
                    {
                        throw new ArgumentOutOfRangeException("Given search key does not exist in this list");
                    }
                    Node nuNode = new Node();
                    nuNode.IntVal = nuValue;
                    nuNode.Next = Current.Next;
                    Current.Next = nuNode;
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}

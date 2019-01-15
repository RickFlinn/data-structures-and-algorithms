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
                Node node = new Node(val);
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
            Node nuNode = new Node(value);
            if (Head == null)
            {
                Head = nuNode;
                Current = Head;
            } else
            {
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = nuNode;
            }
        }

        public void InsertBefore(int key, int nuValue)
        {
            try
            { 
                Current = Head;
                if (Head == null)
                {
                    throw new Exception("This list has no values");
                }
                else if (Current.IntVal == key)
                {
                    Insert(nuValue);
                }
                else
                {
                    while (Current.Next != null && Current.Next.IntVal != key)
                    {
                        Current = Current.Next;
                    }
                    if (Current.Next == null)
                    {
                        throw new ArgumentOutOfRangeException("Given search key does not exist in this list");
                    }
                    Node nuNode = new Node(nuValue, Current.Next);
                    Current.Next = nuNode;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed in InsertBefore - {e.Message}");
                throw e;
            }
        }

        public void InsertAfter(int key, int nuValue)
        {
            try
            {
                Current = Head;

                if (Head == null)
                {
                    throw new Exception("This list has no values");
                }
                else
                {
                    while (Current.IntVal != key && Current.Next != null)
                    {
                        Current = Current.Next;
                    }
                    if (Current.Next == null && Current.IntVal != key)
                    {
                        throw new ArgumentOutOfRangeException("Given search key does not exist in this list");
                    }
                }

                Node nuNode = new Node(nuValue, Current.Next);
                Current.Next = nuNode;

            } catch (Exception e)
            {
                Console.WriteLine($"Failed in InsertAfter - {e.Message}");
                throw e;
            }
        }
        
    }
}

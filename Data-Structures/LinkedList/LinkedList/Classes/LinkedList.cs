using System;
using System.Collections.Generic;
using System.Text;
using LinkedListChallenge;

namespace LinkedListChallenge.Classes
{
    public class LinkedList
    {

        public Node Head { get; set; }
        public Node Current { get; set; }

        /// <summary>
        ///     Takes in an integer, creates a node to store that integer,
        ///     and inserts the integer at the beginning of the list.
        /// </summary>
        /// <param name="val"></param>
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

        /// <summary>
        ///     Checks the linked list for the given value. If the linked list
        ///     contains the given value, returns true; otherwise returns false.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if value found; False if not</returns>
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

        /// <summary>
        ///     Prints all values stored in the linked list to the Console.
        /// </summary>
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

        /// <summary>
        ///     Takes in an integer, creates a node containing that integer,
        ///     and appends the node to the end of the list.
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        ///     Takes in a search key and a value, looks for the search key within 
        ///     the linked list; if the search key is matched with the value in a node,
        ///     a new node containing the given value is created and inserted before
        ///     the node containing the search key.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="nuValue"></param>
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

        /// <summary>
        ///     Takes in a search key and a value, looks for the search key within 
        ///     the linked list; if the search key is matched with the value in a node,
        ///     a new node containing the given value is created and inserted after
        ///     the node containing the search key.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="nuValue"></param>
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

        public int KthFromEnd(int k)
        {
            try
            {
                if (k < 0)
                {
                    throw new ArgumentOutOfRangeException("value of k cannot be negative");
                }
                Current = Head;
                int listLength = 0;
                while (Current != null)
                {
                    Current = Current.Next;
                    listLength++;
                }
                Console.WriteLine($"Length is {listLength}");
                Current = Head;
                if (listLength < k)
                {
                    throw new ArgumentOutOfRangeException("value of k is greater than length of list");
                }
                for (int i = 1; i < listLength - k; i++)
                {
                    Current = Current.Next;
                }
                Console.WriteLine(Current.IntVal);
                return Current.IntVal;
            } catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        
    }
}

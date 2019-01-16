using System;
using LinkedListChallenge.Classes;

namespace LinkedListChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList nuList = new LinkedList();
            nuList.Insert(4);
            nuList.Insert(6);
            nuList.Insert(2);
            nuList.Append(42);
            nuList.InsertAfter(2, 3);
            nuList.InsertAfter(42, 43);
            nuList.InsertBefore(6, 5);
            nuList.InsertBefore(43, 41);
            nuList.PrintListValues();

            nuList.KthFromEnd(2);
            nuList.KthFromEnd(6);
            nuList.KthFromEnd(7);

            nuList.KthFromEnd(0);
        }
        
    }
}

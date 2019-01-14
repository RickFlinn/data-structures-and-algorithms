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
            Console.WriteLine(nuList.Includes(6));
            Console.WriteLine(nuList.Includes(2));
            Console.WriteLine(nuList.Head.IntVal);
            nuList.PrintListValues();
        }
        
    }
}

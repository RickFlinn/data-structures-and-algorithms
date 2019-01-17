using System;
using LinkedListChallenge.Classes;

namespace LinkedList_Merge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            Random rand = new Random();

            for (int i = 0; i < rand.Next(0, 15); i++)
            {
                list1.Append(i * 2 + 1);
            }

            for (int i = 1; i < rand.Next(0, 15); i++)
            {
                list2.Append(i * 2);
            }

            BetterPrint(list1);
            BetterPrint(list2);
            BetterPrint(Merge(list1, list2));

        }

        public static LinkedList Merge(LinkedList list1, LinkedList list2)
        {
            list1.Current = list1.Head;
            list2.Current = list2.Head;

            if (list1.Current == null)
            {
                return list2;
            }

            Node zipper = list1.Current;

            while (list1.Current.Next != null && list2.Current != null)
            {
                list1.Current = list1.Current.Next;
                zipper.Next = list2.Current;
                zipper = zipper.Next;
                list2.Current = list2.Current.Next;
                zipper.Next = list1.Current;
                zipper = zipper.Next;
            }

            if (list2.Current != null)
            {
                zipper.Next = list2.Current;
            }
            
            return list1;
        }

        public static void BetterPrint(LinkedList list)
        {
            Console.Write(list.Head.IntVal);
            list.Current = list.Head.Next;
            while (list.Current != null)
            {
                Console.Write($" -> {list.Current.IntVal}");
                list.Current = list.Current.Next;
            }
            Console.WriteLine();
        }
    }

    
}

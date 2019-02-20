using HashTables;
using System;
using System.Collections;
using System.Collections.Generic;
using Trees.Classes;

namespace Tree_Intersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree<int> tree = new BinaryTree<int>();
        }


        public static List<int> TreeIntersection(BinaryTree<int> tree1, BinaryTree<int> tree2)
        {
            Stack stack = new Stack();
            HashTable cashTable = new HashTable();
            List<int> commons = new List<int>();

            stack.Push(tree1.Root);
            while(stack.Count > 0)
            {
                TreeNode<int> node = (TreeNode<int>)stack.Pop();

                if (!cashTable.Contains(node.Value.ToString()))
                    cashTable.Add(node.Value.ToString(), node.Value);

                if (node.Left != null) stack.Push(node.Left);
                if (node.Right != null) stack.Push(node.Right);
            }

            stack.Push(tree2.Root);
            while(stack.Count > 0)
            {
                TreeNode<int> node = (TreeNode<int>)stack.Pop();

                if (cashTable.Contains(node.Value.ToString()))
                    commons.Add(node.Value);

                if (node.Left != null) stack.Push(node.Left);
                if (node.Right != null) stack.Push(node.Right);
            }

            return commons;

        }


        public static List<int> BSTIntersection(BinarySearchTree tree1, BinarySearchTree tree2)
        {
            Stack stack = new Stack();
            HashTable cashTable = new HashTable();
            List<int> commons = new List<int>();

            stack.Push(tree1.Root);
            while (stack.Count > 0)
            {
                TreeNode<int> node = (TreeNode<int>)stack.Pop();

                if (!cashTable.Contains(node.Value.ToString()))
                    cashTable.Add(node.Value.ToString(), node.Value);

                if (node.Left != null) stack.Push(node.Left);
                if (node.Right != null) stack.Push(node.Right);
            }


        }
    }
}

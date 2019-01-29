using System;
using Trees.Classes;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            int[] treeVals = new int[] { 4, 3, 87, 26, 30, 1, -3, 14, 10, 36 };
            foreach (int val in treeVals)
            {
                tree.Add(val);
            }
        }


        public static void FizzBuzzTree(BinaryTree tree)
        {
            FizzBuzzTreeHelper(tree.Root);
            
        }

        public static void FizzBuzzTreeHelper(TreeNode node)
        {
            if (node != null)
            {
                if (node.Value % 3 == 0)
                {
                    node.Value = "Fizz";
                } else if (node.Value % 5 == 0)
                {
                    node.Value = "Buzz";
                } else if (node.Value % 3 == 0 && node.Value % 5 == 0)
                {
                    node.Value = "FizzBuzz";
                }
            }
        }
    }
}

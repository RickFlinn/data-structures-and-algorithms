using System;
using Trees.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<object> tree = new BinaryTree<object>();
            
            tree.Root = new TreeNode<object>(new TreeNode<object>(15), 4, new TreeNode<object>(5));
        }
        
        // Traverses over tree, converting each value that is divisible by 3, 5, or both to "Fizz", "Buzz", or "FizzBuzz".
        public static void FizzBuzzTree(BinaryTree<object> tree)
        {
            FizzBuzzTreeHelper(tree.Root);
            
        }

        // Takes in a node as a parameter, and if the Node isn't null, checks if the node's value is divisible by 3 and 5.
        //   If so, its value is reassigned to "FizzBuzz". 
        //   If the value is only divisible by 3, reassign it to "Fizz".
        //   If the value is only divisible by 5, reassign it to "Buzz".
        //  Then, the method calls itself on the given node's children.
        public static void FizzBuzzTreeHelper(TreeNode<object> node)
        {
            try
            {
                if (node != null)
                {
                    if ((int)node.Value % 3 == 0 && (int)node.Value % 5 == 0)
                    {
                        node.Value = "FizzBuzz";
                    }
                    else if ((int)node.Value % 3 == 0)
                    {
                        node.Value = "Fizz";
                    }
                    else if ((int)node.Value % 5 == 0)
                    {
                        node.Value = "Buzz";
                    }
                    FizzBuzzTreeHelper(node.Left);
                    FizzBuzzTreeHelper(node.Right);
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}

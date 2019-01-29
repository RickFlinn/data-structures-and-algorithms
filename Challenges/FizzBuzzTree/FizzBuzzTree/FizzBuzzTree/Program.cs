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
        
        // Traverses over 
        public static void FizzBuzzTree(BinaryTree<object> tree)
        {
            FizzBuzzTreeHelper(tree.Root);
            
        }

        public static void FizzBuzzTreeHelper(TreeNode<object> node)
        {
            try
            {
                if (node != null)
                {
                    if ((int)node.Value % 3 == 0 && (int)node.Value % 5 == 0)
                    {
                        node.Value = "FizzBuzz";
                    } else if ((int)node.Value % 3 == 0)
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

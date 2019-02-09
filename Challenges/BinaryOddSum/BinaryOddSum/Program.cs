using System;
using System.Collections;
using Trees.Classes;

namespace BinaryOddSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        // Takes in a binary tree containing integer values, and returns the sum
        //  of all odd values in the tree. 
        public static int BinaryOddSum(BinaryTree<int> tree)
        {
            int sum = 0;
            if (tree.Root == null)
            {
                return sum;
            }
            Queue q = new Queue();
            q.Enqueue(tree.Root);
            while (q.Count > 0)
            {
                TreeNode<int> node = (TreeNode<int>)q.Dequeue();
                if (node.Value % 2 == 1)
                {
                    sum += node.Value;
                }
                if (node.Left != null)
                {
                    q.Enqueue(node.Left);
                }
                if(node.Right != null)
                {
                    q.Enqueue(node.Right);
                }
            }
            return sum;
        }
    }
}

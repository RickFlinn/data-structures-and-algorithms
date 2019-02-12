using System;
using Trees.Classes;

namespace CalcBinaryTreeHeight
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                tree.Add(rand.Next(100));
            }
        }

        /// <summary>
        ///     Takes in a binary tree node, and returns the height of the tree as an integer.
        /// </summary>
        /// <param name="node"> Root node of the tree</param>
        /// <returns> Number of levels in the tree </returns>
        public static int CalcBinaryTreeHeight(TreeNode<int> node)
        {
            if (node.Right == null && node.Left == null)
            {
                return 0;
            } else if (node.Left == null)
            {
                return CalcBinaryTreeHeight(node.Right) + 1;
            } else if (node.Right == null)
            {
                return CalcBinaryTreeHeight(node.Left)+ 1;
            } else
            {
                int leftDepth = CalcBinaryTreeHeight(node.Left) + 1;
                int rightDepth = CalcBinaryTreeHeight(node.Right) + 1;
                return leftDepth > rightDepth ? leftDepth : rightDepth;
            }
        }

        /// <summary>
        ///     Takes in a binary tree node, and returns the number of levels in the tree.
        /// </summary>
        /// <param name="node"> Root node of the tree</param>
        /// <returns> Number of levels in the tree </returns>
        public static int CalcBinaryTreeLevels(TreeNode<int> node)
        {
            if (node.Right == null && node.Left == null)
            {
                return 1;
            }
            else if (node.Left == null)
            {
                return CalcBinaryTreeLevels(node.Right) + 1;
            }
            else if (node.Right == null)
            {
                return CalcBinaryTreeLevels(node.Left) + 1;
            }
            else
            {
                int leftDepth = CalcBinaryTreeLevels(node.Left) + 1;
                int rightDepth = CalcBinaryTreeLevels(node.Right) + 1;
                return leftDepth > rightDepth ? leftDepth : rightDepth;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree
    {
        public BinaryTree Tree { get; set; }

        public BinarySearchTree ()
        {
            Tree = new BinaryTree();
        }

        public BinarySearchTree(TreeNode rootNode)
        {
            Tree = new BinaryTree();
            Tree.Root = rootNode;
        }

        public void Add(int val)
        {
            try
            {
                if (Tree.Root == null)
                {
                    Tree.Root = new TreeNode(val);
                } else
                {
                    AddHelper(Tree.Root, val);
                }
            } catch (Exception e)
            {
                Console.Write("Could not add given value: ");
                Console.WriteLine(e.Message);
            }
        }

        private void AddHelper(TreeNode node, int val)
        {
            if (val < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode(val);
                } else
                {
                    AddHelper(node.Left, val);
                }
            } else
            {
                if (node.Right == null)
                {
                    node.Right = new TreeNode(val);
                } else
                {
                    AddHelper(node.Right, val);
                }
            }
        }

        public bool Contains(int val)
        {
            try
            {

            } catch (Exception e)
            {
                Console.Write("Error finding value in binary search tree: ");
                Console.WriteLine(e.Message);
            }
            return ContainHelper(Tree.Root, val);
            
        }

        private bool ContainHelper(TreeNode node, int val)
        {
            if (node == null)
            {
                return false;
            } else if (val == node.Value)
            {
                return true;
            } else
            {
                return ContainHelper(node.Left, val) || ContainHelper(node.Right, val);
            }
        }
   
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree : BinaryTree
    {
        
        public BinarySearchTree ()
        {
            
        }

        public BinarySearchTree(int rootVal)
        {
            Root = new TreeNode(rootVal);
        }


        /// <summary>
        ///     Adds a new TreeNode with the given value to the BinarySearchTree. 
        ///      Uses recursive helper method to find the correct place for and add the new TreeNode.
        /// </summary>
        /// <param name="val"> Value to add to the Binary Search Tree</param>
        public void Add(int val)
        {
            try
            {
                if (Root == null)
                {
                    Root = new TreeNode(val);
                } else
                {
                    AddHelper(Root, val);
                }
            } catch (Exception e)
            {
                Console.Write("Could not add given value: ");
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        ///     Takes in a TreeNode and an integer value. Checks the value against the value in the given node.
        ///       If the given integer is smaller, checks if the given TreeNode has a Left child.
        ///         If it doesn't, the Left child becomes a new Node with the given value.
        ///         If it does, AddHelper calls itself on the Left child node.
        ///       If the given integer isn't smaller, checks if the given TreeNode has a Right child.
        ///         If it doesn't, the Right child becomes a new Node with the given value.
        ///         If it does, AddHelper calls itself on the Right child node.
        /// </summary>
        /// <param name="node"> "Current" Node </param>
        /// <param name="val"> value to add to the Binary Search Tree </param>
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

        /// <summary>
        ///     Checks each Node in the binary search tree for the given value. 
        /// </summary>
        /// <param name="val"> Value to check the tree for </param>
        /// <returns> Boolean indicating whether the given value exists within the tree </returns>
        public bool Contains(int val)
        {
            try
            {
                return ContainHelper(Root, val);
            } catch (Exception e)
            {
                Console.Write("Error finding value in binary search tree: ");
                Console.WriteLine(e.Message);
            }
            return false;
            
        }

        /// <summary>
        ///     Recursive helper function that checks if the given TreeNode, or its children,
        ///       contain the given integer. 
        /// </summary>
        /// <param name="node"> "Current" TreeNode being examined </param>
        /// <param name="val"> Value to search the tree for </param>
        /// <returns> Boolean indicating whether the Node or its children contain the given integer. </returns>
        private bool ContainHelper(TreeNode node, int val)
        {
            if (node == null)
            {
                return false;
            } else if (val == node.Value)
            {
                return true;
            } else if (val < node.Value)
            {
                return ContainHelper(node.Left, val);
            } else
            {
                return ContainHelper(node.Right, val);
            }
        }
    }
}
